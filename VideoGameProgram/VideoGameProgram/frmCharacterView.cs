namespace VideoGameProgram
{
    public partial class frmCharacterView : Form
    {
        public frmCharacterView()
        {
            InitializeComponent();
        }

        // create a list to hold the characters we create
        private List<Character> exisitingCharacters = new List<Character>();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            string charName = textName.Text;
            int health = (int)numHealth.Value;

            // take the inventory string and convert to an array and then a list
            List<string> inventory = textInventory.Text.Split(',').ToList();

            int attack = (int)numAttack.Value;
            int speed = (int)numSpeed.Value;
            int defense = (int)numDefense.Value;

            // create a new character object using the values from the form
            Character newCharacter = new Character(charName, health, inventory, attack, speed, defense);

            lblCharacterInfo.Text = newCharacter.Display();

            //add new character to the list of existing characters
            exisitingCharacters.Add(newCharacter);

            // reload the characters in the listbox to include the new character
            LoadCharacters();

        }
        //create a method to load the existing characters into the character listbox
        private void LoadCharacters()
        {
            lbCharacters.Items.Clear();
            // loop through the list of existing characters and add their names to the listbox
            foreach (Character character in exisitingCharacters)
            {
                // use the Display method to show the character's name and health in the listbox
                lbCharacters.Items.Add(character.Display());
            }
        }

        private void lbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            //remove any items currently in the inventory list
            lbInventory.Items.Clear();
            // get the selected character from the listbox using the selected index and display their info in the label
            Character selCharacter = exisitingCharacters[lbCharacters.SelectedIndex];

            // let user know if the character has no inventory
            if (selCharacter.Inventory.Count == 0)
            {
                lblCharacterInfo.Text = $"{selCharacter.Name} has no inventory.";
            }
            else
            {
                foreach(string item in selCharacter.Inventory)
                {
                    lbInventory.Items.Add(item.Trim());
                }
            }
        }
    }
}
