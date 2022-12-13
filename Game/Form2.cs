global using System.Data;
global using System.Drawing;
global using System.Windows.Forms;
using WMPLib;
using Game.Entity;
using System.ComponentModel;
using Game.Options;

namespace Game;

public partial class Form2 : Form
{
    public string _category;
    private readonly GameDb _dbContext;
    public List<Building> buildingList = new List<Building>();
    WindowsMediaPlayer player = new WindowsMediaPlayer();
    
    public Form2(string category)
    {
        InitializeComponent();
        
        _category = category;
        var optionBuilder = new DbContextOptionsBuilder<GameDb>()
            .UseSqlite(@"Data Source=C:\Users\User\Desktop\Programy\Game\DB\FoodCalculatorDB.db");
        var dbContext = new GameDb(optionBuilder.Options);
        _dbContext = dbContext;

    }

    private async void Form2_Load(object sender, EventArgs e)
    {
        player.URL = "alexander-nakarada-tavern-loop-one.mp3";
        player.settings.setMode("loop", true);
        await Task.Run(() => player.controls.play());
        var Starter = new GameStarter(_dbContext, this);
        Starter.Start();
        var Buildings = _dbContext.Buildings
            .Where(B => ((B.Category == ("Neutral")  || B.Category == (_category))&&B.Level == 1));
        foreach (var Building in Buildings)
        {
            listBox1.Items.Add(Building.ToString());
            buildingList.Add(Building);
        }
    }

    private void addButtom_Click(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}