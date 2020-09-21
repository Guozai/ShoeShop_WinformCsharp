using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Shop
{
    public partial class FormMain : Form
    {
        private string filename; // string to store the filename of the file opened
        private List<Shoe> shoes = new List<Shoe>(); // create a private list as part of this form to store all shoes
        
        private int indexShoes = 0; // pointer pointing to the current item in the list shoes
        private int indexColors = 0;
        private double myMoney = 300.0; // set initial money of user to $300

        private bool isComboBoxSelectionChanged = false;

        private List<int> nameSearchIndexes = new List<int>(); // internal list to save the search result of matching indexes of shoes
        private bool isDisplayNameSearchResult = false;
        private bool isDisplayPriceSearchResult = false;
        private int indexNameSearchIndexes = 0; // pointer pointing to the current item in the list to save the matching indexes of shoes
        private List<Shoe> priceSearchResults = new List<Shoe>(); // temporary internal list to save the list all matching shoes by price

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // add an event handler when comboBoxColor select is changed
            comboBoxColor.SelectedIndexChanged += new EventHandler(comboBoxColor_SelectedIndexChanged);
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (indexColors != comboBoxColor.SelectedIndex)
                isComboBoxSelectionChanged = true;
            else
                isComboBoxSelectionChanged = false;

            indexColors = comboBoxColor.SelectedIndex; // save the selected index number in indexColors variable

            if (isComboBoxSelectionChanged)
                displayShoeAtIndex(indexShoes, indexColors); // refresh the display
        }

        private void displayShoeAtIndex(int indexShoes, int indexColors)
        {
            // set image path to display shoe image
            pictureBoxShoe.ImageLocation = shoes[indexShoes].Colors[indexColors].PicturePath;
            pictureBoxShoe.Refresh();

            comboBoxColor.Items.Clear(); // clear the comboBox first
            foreach (var color in shoes[indexShoes].Colors)
            {
                switch (color.Color) {
                    case 0:
                        comboBoxColor.Items.Add("Black/White"); // fill the comboBox with colors
                        break;
                    case 1:
                        comboBoxColor.Items.Add("Black"); // fill the comboBox with colors
                        break;
                    case 2:
                        comboBoxColor.Items.Add("Navy/White");
                        break;
                    case 3:
                        comboBoxColor.Items.Add("Black/Pink");
                        break;
                    case 4:
                        comboBoxColor.Items.Add("White/Silver");
                        break;
                    case 5:
                        comboBoxColor.Items.Add("Gray/Black");
                        break;
                    case 6:
                        comboBoxColor.Items.Add("Black/Black");
                        break;
                    case 7:
                        comboBoxColor.Items.Add("Black/Gray");
                        break;
                    case 8:
                        comboBoxColor.Items.Add("Navy");
                        break;
                    case 9:
                        comboBoxColor.Items.Add("Gray/Pink");
                        break;
                    case 10:
                        comboBoxColor.Items.Add("Taupe/Pink");
                        break;
                    case 11:
                        comboBoxColor.Items.Add("Charcoal");
                        break;
                    case 12:
                        comboBoxColor.Items.Add("Natural");
                        break;
                    case 13:
                        comboBoxColor.Items.Add("Burgundy/Pink");
                        break;
                    case 14:
                        comboBoxColor.Items.Add("Gray");
                        break;
                    case 15:
                        comboBoxColor.Items.Add("Purple");
                        break;
                    case 16:
                        comboBoxColor.Items.Add("Mauve");
                        break;
                    case 17:
                        comboBoxColor.Items.Add("Blue");
                        break;
                    default:
                        comboBoxColor.Items.Add(" ");
                        break;
                }
            }
            comboBoxColor.SelectedIndex = indexColors; // select the first color by default

            labelName.Text = shoes[indexShoes].Name; // display shoe name
            // display the price of the first color
            labelPrice.Text = shoes[indexShoes].Colors[indexColors].Price.ToString();
        }

        private void saveFile(string filename)
        {
            StreamWriter outputStream;
            if (filename != null)
            {
                outputStream = File.CreateText(filename);
                foreach (var shoe in shoes)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int index = 0; index < shoe.Colors.Count; index ++)
                    {
                        // build level 3 string
                        stringBuilder.Append(shoe.Colors[index].Color.ToString());
                        stringBuilder.Append('#');
                        stringBuilder.Append(shoe.Colors[index].PicturePath);
                        stringBuilder.Append('#');
                        stringBuilder.Append(shoe.Colors[index].Price);
                        stringBuilder.Append('#');
                        stringBuilder.Append(shoe.Colors[index].Stock);
                        
                        // append % for level 2
                        if (index < shoe.Colors.Count - 1)
                            stringBuilder.Append('%');
                    }

                    outputStream.WriteLine("{0}^{1}^{2}", shoe.Id, shoe.Name, stringBuilder.ToString());
                }

                outputStream.Close();
            }
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "c:\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                StreamReader inputStream = new StreamReader(openFileDialog.FileName);

                string line;
                while ((line = inputStream.ReadLine()) != null)
                {
                    string[] level1_parts = line.Split('^');
                    int id;
                    if (level1_parts.Length == 3 && int.TryParse(level1_parts[0], out id))
                    {
                        List<MyColor> colors = new List<MyColor>();

                        string[] level2_parts = level1_parts[2].Split('%');
                        for (int i = 0; i < level2_parts.Length; i++)
                        {
                            string[] level3_parts = level2_parts[i].Split('#');
                            int color;
                            double price;
                            int stock;
                            if (level3_parts.Length == 4 && int.TryParse(level3_parts[0], out color) && double.TryParse(level3_parts[2], out price) && int.TryParse(level3_parts[3], out stock))
                            {
                                colors.Add(new MyColor() { Color = color, PicturePath = level3_parts[1], Price = price, Stock = stock });
                            }
                        }

                        shoes.Add(new Shoe() { Id = id, Name = level1_parts[1], Colors = colors });
                    }
                }

                inputStream.Close();

                displayShoeAtIndex(indexShoes, indexColors);

                // display the amount of money in hand
                textBoxMoney.Text = myMoney.ToString();
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            saveFile(filename);
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            saveFile(filename);
            Application.Exit();
        }

        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All text files|*.txt"; // set the save file dialog filter to only allow .txt files
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                saveFile(saveFileDialog.FileName);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (isDisplayNameSearchResult)
            {
                if (indexNameSearchIndexes > 0)
                {
                    indexNameSearchIndexes--;
                    indexColors = 0;
                    displayShoeAtIndex(nameSearchIndexes[indexNameSearchIndexes], indexColors);
                }
            }
            else if (isDisplayPriceSearchResult)
            {
                if (indexShoes > 0)
                {
                    indexShoes--;
                    indexColors = 0; // reset
                    displaySearchResult(indexShoes, indexColors);
                }
            }
            else
            {
                if (indexShoes > 0)
                {
                    indexShoes--;
                    indexColors = 0; // reset indexColors to display the first color from the drop down list
                    displayShoeAtIndex(indexShoes, indexColors);
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (isDisplayNameSearchResult)
            {
                if (indexNameSearchIndexes < nameSearchIndexes.Count - 1)
                {
                    indexNameSearchIndexes++;
                    indexColors = 0; // reset
                    displayShoeAtIndex(nameSearchIndexes[indexNameSearchIndexes], indexColors);
                }
            }
            else if (isDisplayPriceSearchResult)
            {
                if (indexShoes < priceSearchResults.Count - 1)
                {
                    indexShoes++;
                    indexColors = 0;
                    displaySearchResult(indexShoes, indexColors);
                }
            }
            else
            {
                if (indexShoes < shoes.Count - 1)
                {
                    indexShoes++;
                    indexColors = 0; // reset
                    displayShoeAtIndex(indexShoes, indexColors);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit(this, myMoney);
            formEdit.Show();
        }

        public void updateMyMoney(double myMoney)
        {
            this.myMoney = myMoney;
        }

        public void refreshTextBoxMoney(double myMoney)
        {
            textBoxMoney.Text = myMoney.ToString();
        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {
            if (!textBoxName.Text.Equals(""))
            {
                nameSearchIndexes.Clear(); // clear the temporary result list to remove the result by former other searches
                for (int index = 0; index < shoes.Count; index++)
                {
                    if (shoes[index].Name.Contains(textBoxName.Text))
                        nameSearchIndexes.Add(index); // add a shoe index to the result list (not the shoe class item itself)
                }
                if (nameSearchIndexes.Count == 0)
                    MessageBox.Show("No Result!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    indexColors = 0;
                    displayShoeAtIndex(nameSearchIndexes[indexNameSearchIndexes], indexColors);
                    isDisplayNameSearchResult = true;
                }
            }
        }

        private void buttonSearchByPrice_Click(object sender, EventArgs e)
        {
            if (!textBoxPriceLow.Text.Equals("") && !textBoxPriceHigh.Text.Equals(""))
            {
                bool isShoeHasPriceSearched = false;

                double priceLow;
                double priceHigh;
                if (double.TryParse(textBoxPriceLow.Text, out priceLow) && double.TryParse(textBoxPriceHigh.Text, out priceHigh))
                {
                    if (priceLow <= priceHigh)
                    {
                        nameSearchIndexes.Clear(); // clear the list to save results
                        priceSearchResults.Clear();
                        for (int index = 0; index < shoes.Count; index++)
                        {
                            List<MyColor> colors = new List<MyColor>(); // create a temp color list that store the colors matching the price searched

                            for (int i = 0; i < shoes[index].Colors.Count; i++)
                            {
                                if (shoes[index].Colors[i].Price >= priceLow && shoes[index].Colors[i].Price <= priceHigh)
                                {
                                    // add the shoe to the result shoe list
                                    isShoeHasPriceSearched = true;
                                    // add the color to the result color list
                                    colors.Add(new MyColor() { Color = shoes[index].Colors[i].Color, PicturePath = shoes[index].Colors[i].PicturePath, 
                                        Price = shoes[index].Colors[i].Price, Stock = shoes[index].Colors[i].Stock });
                                }
                            }
                            if (isShoeHasPriceSearched)
                                priceSearchResults.Add(new Shoe() { Id = shoes[index].Id, Name = shoes[index].Name, Colors = colors });
                        }

                        if (priceSearchResults.Count > 0)
                        {
                            indexShoes = 0;
                            indexColors = 0;
                            displaySearchResult(indexShoes, indexColors);
                            isDisplayPriceSearchResult = true;
                        }
                        else
                            MessageBox.Show("No Result Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Lower Price must be smaller than Higher Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Prices must be numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Must have prices!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDisplayAllShoes_Click(object sender, EventArgs e)
        {
            isDisplayNameSearchResult = false;
            isDisplayPriceSearchResult = false;
            indexShoes = 0; // reset
            indexColors = 0; // reset
            displayShoeAtIndex(indexShoes, indexColors);
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            double price;
            double.TryParse(labelPrice.Text, out price);
            if (myMoney >= price)
            {
                if (!isDisplayPriceSearchResult)
                {
                    if (shoes[indexShoes].Colors[indexColors].Stock > 0)
                    {
                        myMoney -= double.Parse(labelPrice.Text);
                        shoes[indexShoes].Colors[indexColors].Stock--;
                        refreshTextBoxMoney(myMoney);
                        saveFile(filename);
                    }
                    else
                        MessageBox.Show("Sorry, Out of stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (priceSearchResults[indexShoes].Colors[indexColors].Stock > 0)
                    {
                        myMoney -= double.Parse(labelPrice.Text);
                        // try to find corresponding shoes element's stock, and make stock - 1 
                        foreach (var shoe in shoes)
                        {
                            if (shoe.Id == priceSearchResults[indexShoes].Id)
                            {
                                foreach (var color in shoe.Colors)
                                {
                                    if (color.Color == priceSearchResults[indexShoes].Colors[indexColors].Color)
                                    {
                                        color.Stock--; // find the correct element in shoes and decrease its stock by 1
                                        priceSearchResults[indexShoes].Colors[indexColors].Stock--; // sync
                                    }
                                }
                            }
                        }
                        shoes[indexShoes].Colors[indexColors].Stock--;
                        refreshTextBoxMoney(myMoney);
                        saveFile(filename);
                    }
                    else
                        MessageBox.Show("Sorry, Out of stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Not enough money to buy!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }

        private void displaySearchResult(int indexShoes, int indexColors)
        {
            // set image path to display shoe image
            pictureBoxShoe.ImageLocation = priceSearchResults[indexShoes].Colors[indexColors].PicturePath;
            pictureBoxShoe.Refresh();

            comboBoxColor.Items.Clear(); // clear the comboBox first
            foreach (var color in priceSearchResults[indexShoes].Colors)
            {
                switch (color.Color)
                {
                    case 0:
                        comboBoxColor.Items.Add("Black/White"); // fill the comboBox with colors
                        break;
                    case 1:
                        comboBoxColor.Items.Add("Black"); // fill the comboBox with colors
                        break;
                    case 2:
                        comboBoxColor.Items.Add("Navy/White");
                        break;
                    case 3:
                        comboBoxColor.Items.Add("Black/Pink");
                        break;
                    case 4:
                        comboBoxColor.Items.Add("White/Silver");
                        break;
                    case 5:
                        comboBoxColor.Items.Add("Gray/Black");
                        break;
                    case 6:
                        comboBoxColor.Items.Add("Black/Black");
                        break;
                    case 7:
                        comboBoxColor.Items.Add("Black/Gray");
                        break;
                    case 8:
                        comboBoxColor.Items.Add("Navy");
                        break;
                    case 9:
                        comboBoxColor.Items.Add("Gray/Pink");
                        break;
                    case 10:
                        comboBoxColor.Items.Add("Taupe/Pink");
                        break;
                    case 11:
                        comboBoxColor.Items.Add("Charcoal");
                        break;
                    case 12:
                        comboBoxColor.Items.Add("Natural");
                        break;
                    case 13:
                        comboBoxColor.Items.Add("Burgundy/Pink");
                        break;
                    case 14:
                        comboBoxColor.Items.Add("Gray");
                        break;
                    case 15:
                        comboBoxColor.Items.Add("Purple");
                        break;
                    case 16:
                        comboBoxColor.Items.Add("Mauve");
                        break;
                    case 17:
                        comboBoxColor.Items.Add("Blue");
                        break;
                    default:
                        comboBoxColor.Items.Add(" ");
                        break;
                }
            }
            comboBoxColor.SelectedIndex = indexColors; // select the first color by default

            labelName.Text = priceSearchResults[indexShoes].Name; // display shoe name
            // display the price of the first color
            labelPrice.Text = priceSearchResults[indexShoes].Colors[indexColors].Price.ToString();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}
