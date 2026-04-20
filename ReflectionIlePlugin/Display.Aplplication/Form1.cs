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

        Dictionary<string,Plug> loadedPlugins = new Dictionary<string,Plug>();
        private void addToMenu(List<Plug> plugs)
        {
            plugs.ForEach(p => {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(p.Name);
                pluginsToolStripMenuItem.DropDownItems.Add(menuItem);
                menuItem.Click += MenuItem_Click;
                loadedPlugins.Add(p.Name, p);
            });
        }


        private void MenuItem_Click(object? sender, EventArgs e)
        {
            var name = (sender as ToolStripMenuItem).Text;
            Plug plug = loadedPlugins[name];
            IPlugin pluginInterface = Helper.CreateInstance(plug);
            pluginInterface.Draw(splitContainer1.Panel2.CreateGraphics(), new SolidBrush(Color.Blue), (int)numericUpDownX.Value, (int)numericUpDownY.Value, (int)numericUpDownWidth.Value, (int)numericUpDownWidth.Value);


        }
    }
}
