using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Windows.Input;

namespace Курсач__Framework_
{
	public partial class mainForm : Form
	{
		public string currentDirectory = Environment.CurrentDirectory;
		public readonly ChromiumWebBrowser pageViewer;
		private void mainForm_Load(object sender, EventArgs e)
		{
			TreeNode startNode = new TreeNode("Довідник");
			treePages.Nodes.Add(startNode);

			AddPagesToTree(startNode);
			startNode.Expand();
		}
		public mainForm()
		{
			InitializeComponent();
			pageViewer = new ChromiumWebBrowser(currentDirectory + "/" + Properties.Settings.Default.currentPage);
			checkFirstUse();
			formContainer.Panel2.Controls.Add(pageViewer);
		}
		void checkFirstUse()
        {
			FileInfo file = new FileInfo("check");
			if (!file.Exists)
            {
				Properties.Settings.Default.currentPage = "/Hello.html";
				File.Create("check");
				pageViewer.Load(currentDirectory + "/Hello.html");
            }
        }
		void AddPagesToTree(TreeNode node)
		{
			string strPath = node.FullPath;

			DirectoryInfo dirInfo = new DirectoryInfo(strPath);
			DirectoryInfo[] arrayDirInfo;
			try
			{
				arrayDirInfo = dirInfo.GetDirectories();
			}
			catch
			{
				return;
			}
			foreach (FileInfo f in dirInfo.GetFiles())
			{
				if (f.Extension.Equals(".html"))
				{
					TreeNode nodeDir = new TreeNode(Path.GetFileNameWithoutExtension(f.Name));
					node.Nodes.Add(nodeDir);
				}
			}
			foreach (DirectoryInfo dir in arrayDirInfo)
			{
				TreeNode nodeDir = new TreeNode(dir.Name);
				node.Nodes.Add(nodeDir);
				AddPagesToTree(nodeDir);
			}
		}
		private void backButton_Click(object sender, EventArgs e)
		{
			pageViewer.Back();
			Console.WriteLine("Back");
		}
		private void nextButton_Click(object sender, EventArgs e)
		{
			pageViewer.Forward();
			Console.WriteLine("Forward");
		}
		public void pageListTo(string where)
		{
			try
			{
				if (!File.Exists(currentDirectory + where))
				{
					throw new FileNotFoundException();
				}
				else
				{
					pageViewer.Load(currentDirectory + where);
					updatePageNumber(where);
				}
			}
			catch (Exception i)
			{
				Console.WriteLine(i);
				pageViewer.Load(currentDirectory + "/errors/" + 404 + ".html");
			}
		}
		public void updatePageNumber(string currentPage)
		{
			currentPageLabel.Text = "Cторінка: " + currentPage;
		}
		private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
		}
		private void mainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData.ToString() == "F, Control")
			{
				if (searchButton.Checked || searchGroupBox.Enabled)
				{
					searchGroupBox.Enabled = false;
					searchGroupBox.Visible = false;
					searchButton.Checked = false;
					pageViewer.StopFinding(true);
				}
				else
				{
					searchGroupBox.Enabled = true;
					searchGroupBox.Visible = true;
					searchButton.Checked = true;
					pageViewer.StopFinding(true);
				}
			}
		}
		private void searchButton_Click(object sender, EventArgs e)
		{
			if (searchButton.Checked)
			{
				searchGroupBox.Enabled = true;
				searchGroupBox.Visible = true;
			}
			else
			{
				searchGroupBox.Enabled = false;
				searchGroupBox.Visible = false;
				pageViewer.StopFinding(true);
				
			}
		}
		private void pageList(object sender, TreeViewEventArgs e)
		{
			try
			{
				DirectoryInfo directory = new DirectoryInfo(currentDirectory + "/" + e.Node.FullPath);
				TreeView tree = (TreeView)sender;
				if (directory.Exists)
				{
					e.Node.Expand();
					return;
				}
				if (!File.Exists(currentDirectory + "/" + e.Node.FullPath + ".html"))
				{
					throw new FileNotFoundException();
				}
				else
				{
					pageViewer.Load(currentDirectory + "/" + e.Node.FullPath + ".html");
					Properties.Settings.Default.currentPage = "/" + e.Node.FullPath + ".html";
					updatePageNumber(e.Node.Text);
					Console.WriteLine(e.Node.FullPath);
					Console.WriteLine("Props - " + Properties.Settings.Default.currentPage);
				}
			}
			catch(Exception i)
			{
				Console.WriteLine(i);
				pageViewer.Load(currentDirectory + "/errors/" + 404 + ".html");
			}
		}
		private void pageReload_Click(object sender, EventArgs e)
		{
			pageViewer.Load(currentDirectory + Properties.Settings.Default.currentPage);
		}
		private void aboutAuthor_Click(object sender, EventArgs e)
		{
			aboutAuthor author = new aboutAuthor();
			author.ShowDialog();
		}
		private void backSearch_Click(object sender, EventArgs e)
		{
			pageViewer.Find(0, searchBox.Text, false, false, false);
		}
		private void forwardSearch_Click(object sender, EventArgs e)
		{
			pageViewer.Find(0, searchBox.Text, true, false, false);
		}

        private void aboutProgram_Click(object sender, EventArgs e)
        {
			aboutProgram program = new aboutProgram();
			program.ShowDialog();
        }
		private void changeTheme(object sender, EventArgs e)
        {
			string theme = (sender as ToolStripMenuItem).Name;
			switch (theme)
            {
				case "warmButton":
					BackColor = Color.Linen;
					menuHeader.BackColor = Color.Linen;
					treePages.BackColor = Color.Linen;
					searchGroupBox.BackColor = Color.LemonChiffon;
					formContainer.BackColor = Color.Linen;
					break;
				case "coldButton":
					BackColor = Color.White;
					menuHeader.BackColor = Color.WhiteSmoke;
					treePages.BackColor = Color.White;
					searchGroupBox.BackColor = Color.WhiteSmoke;
					formContainer.BackColor = Color.White;
					break;
				case "grayButton":
					BackColor = Color.Gray;
					menuHeader.BackColor = Color.DimGray;
					treePages.BackColor = Color.Gray;
					searchGroupBox.BackColor = Color.DarkGray;
					formContainer.BackColor = Color.Gray;
					break;
			}
        }

	}
}
