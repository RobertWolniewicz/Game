using Game.Entity;

namespace Game.Options;

internal class GameStarter
{
    private readonly GameDb _dbContext;
    private readonly Form2 _form;
    List<Label> labels = new List<Label>();
    public GameStarter(GameDb dbContext, Form2 form)
    {
        _dbContext = dbContext;
        _form = form;
    }
    public void Start()
    {
        _form.label1.Text = "";
        labels.Add(_form.label1);
        _form.label2.Text = "";
        labels.Add(_form.label2);
        _form.label3.Text = "";
        labels.Add(_form.label3);
        _form.label4.Text = "";
        labels.Add(_form.label4);
        _form.label5.Text = "";
        labels.Add(_form.label5);
        _form.label6.Text = "";
        labels.Add(_form.label6);
        _form.label7.Text = "";
        labels.Add(_form.label7);
        _form.label8.Text = "";
        labels.Add(_form.label8);
        _form.label9.Text = "";
        labels.Add(_form.label9);
        _form.label10.Text = "";
        labels.Add(_form.label10);
        switch(_form._category)
        {
            case "Trade":
                
                break;
        }
    }
}
