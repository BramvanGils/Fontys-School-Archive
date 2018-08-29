using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OISFileHandeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("C:\\Users\\Bramv\\Desktop\\qweLKSJCLKSDJLKDSLKVDSLKJVDNVKJDSLKFDJLKFDJVFDJVKDJVKDSJVSDJDSJKVSVXJVKJDCLKJSJCLKVSJLKDSJVJNVKJXJVJSKJVCJKDSDJKJKSJLKLKVJSLKDNDNDLKNVLXNDVKNSLKDVNSDVNKSNDVNSVLKSDLKJKSN,CNSLVNDSLKVSVLKJSLVNDSLKVNDSNVLKSDNVKSNVLNSLKDLSKNVNSLKDVNLKSNDVLNSLKNVLKSNKVNSJDNLVHSILKNSLKVNSDVNSLKDNZSNDKLVJBADIJSJRHLKJjheohroeghoghdkjghsdkjghosfhkjshgkjdhfgbehgiehdufhdifukdjfhgoiudhfjnsfdvhdkjfjkdhkgjghdjhfighdvjbrrufhyfhhrybvjdhhbfdkhjdiufkdhshfkshlrjhsfkhjghslfghskjdfhgishgkjsfdhgflkjshfkjshkgshdgfklshdfgsdfglkjsdfhglkjjdhsfglkshdfglkjsdhglksdjhfglksjdfhglsdhflkjshfgkjshdfglkjjshfdgnlkjhsdfglosdhfglkjsdhfgnlskdhfglksjhdfglkjsdhfnglkjsdfkvjnxkcjhvkjdshfhsdkfjhgsiudfhgusdofghsdofgjosidfjgosjdlgjskfgjsr\\the meaning of life the universe and everything.txt", TextInput.Text);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("Het Pad is te lang");
            }
            catch
            {
                MessageBox.Show("An error occured");
            }
        }
    }
}
