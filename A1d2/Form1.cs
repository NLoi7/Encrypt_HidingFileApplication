using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace A1d2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static byte[] coverFileBytes, messageFileBytes, stegoFileBytes, generatedIdBlock;
        private static string coverFileType, messageFileType;
        private static bool coverFileExists, messageFileExists;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable 'Hide' button on 'Hide' tab
            btnEncrypt.Enabled = false;
            // Disable 'Recover' button on 'Recover' tab
            btnDecrypt.Enabled = false;
        }
        // tạo khối block dùng để xác định tính toàn vẹn của message, file trước và sau khi mã hóa
        // kích thước block khoảng 64bit
        private void GenerateIdBlock() // tạo các thành phần trong khối ID để check tính toàn vẹn 
            // gồm các thành phần : giá trị hash, file type, key index
        {
            if (coverFileExists && messageFileExists)
            {
                var hashBlock = HashGenerator.GetHash(messageFileBytes); // băm message
                // file hash : xác định tính toàn vẹn 
                // giá trị băm ban đầu được giữ lại sau đó so sánh với tin nhắn được trích xuất 
                var generatedIdString = hashBlock + "|" + messageFileType + "|"; // phân cách 2 thành phần bằng |
                var stegoFileKeyIndex = coverFileBytes.Length.ToString().PadLeft(64 - generatedIdString.Length, '0'); // padding vào keyindex để đủ 64bytes
                //padleft trả về chuỗi mới có độ dài 64-gener , phần đầu chuỗi ( bên trái)  được đêm bằng kí tự 0 
                // [40 bytes hash] + "|" + [x bytes extension] + "|" + [ y bytes key index]
                generatedIdBlock = Encoding.ASCII.GetBytes(generatedIdString + stegoFileKeyIndex); // kết quả cuối cùng là khối IDblock tạo thành một mảng byte
                Debug.WriteLine("Hashblock length: "+hashBlock.Length);
                Debug.WriteLine("Stego key index: " + stegoFileKeyIndex);
                Debug.WriteLine("Total Id Block length: " + generatedIdBlock.Length);

       
                btnEncrypt.Enabled = true;
            }
        }

		private void tbGeneratedKey_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbHelp_TextChanged(object sender, EventArgs e)
		{

		}

		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void groupBoxMessage_Enter(object sender, EventArgs e)
		{

		}

		private void btnBrowseCover_Click(object sender, EventArgs e)
        {
            openCoverFileDialog.Filter = "Image Files (*.BMP; *.JPG; *.PNG)| *.bmp; *.jpg; *.png | PDF Files (*.pdf) | *.pdf";
            DialogResult openCoverFileDialogResult = openCoverFileDialog.ShowDialog();
            if (openCoverFileDialogResult == DialogResult.OK)
            {
                // Read the cover file into bytes, then close it
                coverFileBytes = File.ReadAllBytes(openCoverFileDialog.FileName);
                lblFileNameCover.Text = openCoverFileDialog.SafeFileName;
                lblCoverFileType.Text = coverFileType = Path.GetExtension(openCoverFileDialog.FileName).Substring(1).ToUpper();
                //substring(1) truy xuất chuỗi con bắt đầu từ 1 đến cuối chuỗi, getextension  lấy path
                lblCoverFileSize.Text = (coverFileBytes.LongLength / 1000).ToString() + " KBytes";
                coverFileExists = true; // Tell that cover file exists
            }
            // Attempt to generate id block and unlock form elements
            GenerateIdBlock();  
        }

        private void btnBrowseMessage_Click(object sender, EventArgs e)
        {
            DialogResult openMessageFileDialogResult = openMessageFileDialog.ShowDialog();
            if (openMessageFileDialogResult == DialogResult.OK)
            {
                //chọn file để mã hóa 
                messageFileBytes = File.ReadAllBytes(openMessageFileDialog.FileName); // chuyển sang byte
                lblFileNameMessage.Text = openMessageFileDialog.SafeFileName;
                lblMessageFileType.Text = messageFileType = (Path.GetExtension(openMessageFileDialog.FileName).Length > 1) ? Path.GetExtension(openMessageFileDialog.FileName).Substring(1).ToUpper() : "";
                lblMessageFileSize.Text = (messageFileBytes.LongLength / 1000).ToString() + " KBytes";
                messageFileExists = true; 
            }
           
            GenerateIdBlock();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
			// trim() Xóa tất cả các ký tự khoảng trắng ở đầu và cuối khỏi chuỗi hiện tại.
			if (tbGeneratedKey.Text.Trim().Length < 8)
            {
                MessageBox.Show("Minimum secret passphrase length is 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblStatus.Text = "Processing...";
                saveStegoFileDialog.Filter = String.Format("{1} file (*.{0})|*.{0}", coverFileType.ToLower(), coverFileType);
                DialogResult saveStegoFileDialogResult = saveStegoFileDialog.ShowDialog();
                if (saveStegoFileDialogResult == DialogResult.OK)
                {
                    try
                    {
                        // mã hóa message 
                        var cipherBytes = ByteCipher.Encrypt(messageFileBytes, tbGeneratedKey.Text.Trim());
                        
                        // khi mã hóa thì mã hóa file ,sau đó mã hóa tiếp tục cái idblock rồi được nối sau file đã mã hóa thì ra được cái cipher
                        var cipherBytesWithIdBlock = cipherBytes.Concat(ByteCipher.Encrypt(generatedIdBlock, tbGeneratedKey.Text.Trim())).ToArray();// mã hóa idblock
                        
                        File.WriteAllBytes(saveStegoFileDialog.FileName, coverFileBytes.Concat(cipherBytesWithIdBlock).ToArray());
                        // sau khi mã hóa được cái cipher gồm file mã hóa với idblock, sau đó cả 2 được thêm vào sau file type của coverfile và tạo ra mảng byte  


						//sử dụng để tạo một tệp mới, sau đó ghi mảng byte đã chỉ định vào tệp và sau đó đóng tệp.
                        //Nếu tệp mục tiêu đã tồn tại, nó sẽ bị ghi đè.
						
						DialogResult successDialog = MessageBox.Show("File encrypted and hid successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (successDialog == DialogResult.OK && cbOpenStegoFile.Checked)
                        {
                            Process.Start(saveStegoFileDialog.FileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        
                        lblStatus.Text = "Ready";
                        lblFileNameCover.Text = lblFileNameMessage.Text = "No file chosen";
                        lblCoverFileSize.Text = lblCoverFileType.Text = lblMessageFileSize.Text = lblMessageFileType.Text = "-";
                        coverFileExists = messageFileExists = false;
                        btnEncrypt.Enabled = false;
                    }
                }
                else
                {
                    lblStatus.Text = "Ready";
                }
            }
        }

        private void btnBrowseStego_Click(object sender, EventArgs e)
        {
            DialogResult openStegoFileDialogResult = openStegoFileDialog.ShowDialog();
            if (openStegoFileDialogResult == DialogResult.OK)
            {
                stegoFileBytes = File.ReadAllBytes(openStegoFileDialog.FileName);
                lblFileNameStego.Text = openStegoFileDialog.SafeFileName;
                lblStegoFileSize.Text = (stegoFileBytes.LongLength / 1000).ToString() + " KBytes";
                lblStegoFileType.Text = Path.GetExtension(openStegoFileDialog.FileName).Substring(1).ToUpper();
                btnDecrypt.Enabled = true;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbInputKey.Text.Trim().Length < 8)
            {
                MessageBox.Show("Minimum secret passphrase length is 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    lblStatus.Text = "Processing...";
                    var passphrase = tbInputKey.Text.Trim(); // nhập passphare
                    // đầu tiên lấy Idblock phía cuối file stego
                    var retrievedIdBlockString = Encoding.ASCII.GetString(ByteCipher.Decrypt(stegoFileBytes.Skip(stegoFileBytes.Length - 112).ToArray(), passphrase)).Split('|');
                    if (retrievedIdBlockString.Length != 3) throw new Exception("File is corrupted or invalid");
                    // phần này dùng để check tính toàn vẹn ( công dụng của IDBLock phát huy)
                    var retrievedHash = retrievedIdBlockString[0]; // đầu tiên để check hash
                    var hiddenFileType = retrievedIdBlockString[1].ToLower(); // check file type 
                    var keyindex = Convert.ToInt32(retrievedIdBlockString[2]); // check keyindex
                   
                    // khi đã lấy được index ta biết vị trí của message ở đâu, vì thế ta sẽ  tách nó ra vào một mảng
                    var retrievedCipherBytesWithIdBlock = stegoFileBytes.Skip(keyindex).ToArray();
                    // tách lấy cipher từ IDBlock
                    var retrievedCipherBytes = retrievedCipherBytesWithIdBlock.Take(retrievedCipherBytesWithIdBlock.Length - 112).ToArray();

                  // sau khi đã lấy xong tiến hành mã hóa
                    var retrievedMessageBytes = ByteCipher.Decrypt(retrievedCipherBytes, passphrase);
                    if (retrievedHash != HashGenerator.GetHash(retrievedMessageBytes)) throw new Exception("File has been modified"); // so sánh hash để check tính toàn vẹn

                    saveExtractedFileDialog.Filter = String.Format("{0} file (*.{1})|*.{1}", hiddenFileType.ToUpper(), hiddenFileType);
                    DialogResult saveExtractedFileDialogResult = saveExtractedFileDialog.ShowDialog();
                    if (saveExtractedFileDialogResult == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveExtractedFileDialog.FileName, retrievedMessageBytes);
                        DialogResult successDialog = MessageBox.Show("File extracted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (successDialog == DialogResult.OK && cbOpenRecoveredFile.Checked)
                        {
                            Process.Start(saveExtractedFileDialog.FileName);
                        }
                    }
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                   
                    lblStatus.Text = "Ready";
                    lblFileNameStego.Text = "No file chosen";
                    lblStegoFileSize.Text = lblStegoFileType.Text = "-";
                    btnDecrypt.Enabled = false;
                }
            }
        }
    }
}
