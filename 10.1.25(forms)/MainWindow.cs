using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryInterfaceUtils;
using LibraryLogic;

namespace _10._1._25_forms_
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(InputDataGridView, 40, false, true, true);
            this.openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            this.saveFileDialog.InitialDirectory = Environment.CurrentDirectory;


        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = StudentsDGVConvert.DGVToStudentList(this.InputDataGridView);
                StudentsSorter sorter = new StudentsSorter(students);

                string result = "";

                foreach (Pair pair in sorter.GetStudentsForParty())
                {
                    result += pair.Course + " курс: ";
                    if (pair.Boy == null || pair.Girl == null)
                    {
                        result += "пары нет" + Environment.NewLine;
                    }
                    else
                    {
                        result += pair.Boy.FullName + " и " + pair.Girl.FullName + Environment.NewLine;
                    }
                }

                resultLabel.Text = result;
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Ошибка! Данные некорректны!");
            }
        }

        private void openFile_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog.FileName;

                    List<Student> studentsList = StudentsFileUtils.ReadStudentsListFromFile(path);
                    StudentsDGVConvert.StudentListToDGV(InputDataGridView, studentsList);

                    MessagesUtils.Show("Данные загружены из файла");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка чтения из файла");
                }
            }

        }

        private void saveFile_btn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog.FileName;

                    FileUtils.WriteStringToFile(path, resultLabel.Text);

                    MessagesUtils.Show("Данные сохранены в файл");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка сохранения в файл");
                }
            }

        }

        private void InputDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
