using System;
using System.Windows;

namespace module_18_exercise_1
{
    public partial class MainWindow : Window
    {
        Repository zoo; //объявление репозитория zoo
        public MainWindow()
        {
            InitializeComponent();
            zoo = Repository.CreateRepository(); //созание списка животных
            dg_animals.ItemsSource = zoo.animalList; //заполнение datagrid животными
        }
        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            if(tb_typeAnimal.Text != "" && tb_genus.Text != "" && tb_name.Text != "" && tb_breed.Text != "" && tb_age.Text != "")
            {
                zoo.Add(AnimalFactory.GetAnimal(tb_typeAnimal.Text.ToLower(), tb_typeAnimal.Text, tb_genus.Text, tb_name.Text, tb_breed.Text, Int32.Parse(tb_age.Text))); //добавление новго животного через проверку записанного типа
                dg_animals.Items.Refresh(); //обновление datagrid
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            
        }
    }
}
