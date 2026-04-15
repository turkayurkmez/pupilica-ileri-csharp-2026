using Display.SDK;

namespace Display.Aplplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pluginAddMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //Burada, belirtilen klasördeki dll'ler kontrol edilecek ve plugin olanlar menüye eklenecek!
                var plugs = Helper.GetPlugs(folderBrowserDialog.SelectedPath);
                addToMenu(plugs);
            }
        }

        private void addToMenu(List<Plug> plugs)
        {
            plugs.ForEach(p => {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(p.Name);
                pluginsToolStripMenuItem.DropDownItems.Add(menuItem);
            });
        }
    }
}
