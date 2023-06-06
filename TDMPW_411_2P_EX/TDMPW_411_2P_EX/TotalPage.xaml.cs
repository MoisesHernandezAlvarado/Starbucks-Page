using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TDMPW_411_2P_EX;

public partial class TotalPage : ContentPage
{
	List<Tenis> tenis = new List<Tenis>();
    int i = 0;

	public TotalPage()
	{
		InitializeComponent();
		tenis.Add(new Tenis("forum.webp", "Forum Easter Egg", "Casual", "Adulto", "Adidas", 2200));
        tenis.Add(new Tenis("j4.png", "Jordan 4 UNC", "Casual", "Adulto", "Nike JOrdan", 4500));
        tenis.Add(new Tenis("puma.jpg", "Puma LQDCell", "Casual", "Adulto", "Puma", 2500));
        this.imgTenis.Source = tenis[i].image;
        this.lblTitle.Text = tenis[i].title;
        this.lblCategory.Text = tenis[i].category;
        this.lblSize.Text = tenis[i].size;
        this.lblBrand.Text = tenis[i].brand;
        this.lblPrice.Text = $"{tenis[i].price:C}";
        this.lblTotal.Text = $"Total................................{tenis[i].price:C}";
        this.btnTotal.Text = $"Total {tenis[i].price:C}";
    }

    private void tenis3_Clicked(object sender, EventArgs e)
    {
        i = 2;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"{this.stpCantidad.Value}";
        asignarValores();
    }

    private void tenis1_Clicked(object sender, EventArgs e)
    {
        i = 0;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"{this.stpCantidad.Value}";
        asignarValores();
    }

    private void tenis2_Clicked(object sender, EventArgs e)
    {
        i = 1;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"{this.stpCantidad.Value}";
        asignarValores();
    }

    private void asignarValores() {
        this.imgTenis.Source = tenis[i].image;
        this.lblTitle.Text = tenis[i].title;
        this.lblCategory.Text = tenis[i].category;
        this.lblSize.Text = tenis[i].size;
        this.lblBrand.Text = tenis[i].brand;
        calcularPrecio();
    }

    private void calcularPrecio()
    {
        var total = tenis[i].price * this.stpCantidad.Value;
        this.lblPrice.Text = $"{total:C}";
        this.lblTotal.Text = $"Total................................{total:C}";
        this.btnTotal.Text = $"Total {total:C}";
    }

    private void stpCantidad_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        calcularPrecio();
        this.lblCantidad.Text = $"{this.stpCantidad.Value}";
    }
}