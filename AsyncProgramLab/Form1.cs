namespace AsyncProgramLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult result2 = this.openFileDialog2.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                txtFileName2.Text = openFileDialog2.FileName.Split("\\").LastOrDefault();
            }
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = this.openFileDialog1.ShowDialog();
            if (result1 == DialogResult.OK)
            {
                txtFileName1.Text = openFileDialog1.FileName.Split("\\").LastOrDefault();
            }
        }

        //Navya Gupta
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            List<Task> task1 = new List<Task>();

            List<Task> task2 = new List<Task>();

            var file1 = openFileDialog1.FileName;
            var file2 = openFileDialog2.FileName;

            var wordTask1 = ReadBook(file1, listBox1);
            var wordTask2 = ReadBook(file2, listBox2);

            task1.Add(wordTask1);
            task2.Add(wordTask2);

            await Task.WhenAll(task1);
            await Task.WhenAll(task2);
        }

        //Navya Gupta
        private async Task ReadBook(string filename, ListBox targetListBox)
        {
            var lines = await File.ReadAllLinesAsync(filename);

            var arrayLinesCleaned = lines.Where(x => x != string.Empty)
                                                                .AsParallel()
                                                                .Select(x => x.ToLower()
                                                                .Trim()
                                                                .Replace(",", "")
                                                                .Replace("'", "")
                                                                .Replace(".", ""));

            var arrayOfWords = arrayLinesCleaned.SelectMany(x => x.Split(" "));

            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                {
                    wordDic[x]++;
                }
                else
                {
                    wordDic.Add(x, 1);
                }
            });

            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                                .OrderByDescending(x => x.Value).Take(10);

            foreach (var word in top10)
            {
                targetListBox.Items.Add(word.Key + " - " + word.Value);
            }
        }
    }
}
