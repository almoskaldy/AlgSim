using AlgSim.View;
using AlgSim.ViewModel;

namespace AlgSim;

public partial class AppShell : Shell

{

	private MainViewModel _mainViewModel;
	private SumPage_ViewModel _sumPageViewModel;
	private EldontesPage_ViewModel _eldontesPageViewModel;
	private KivalasztasPage_ViewModel _kivalasztasPageViewModel;
    private KeresesPage_ViewModel _keresesPageViewModel;
    private MegszamolasPage_ViewModel _megszamolasPageViewModel;

    public AppShell(MainViewModel mainViewModel)
	{
		InitializeComponent();

		_mainViewModel = mainViewModel;
		_sumPageViewModel = new SumPage_ViewModel();
		_eldontesPageViewModel = new EldontesPage_ViewModel();
		_kivalasztasPageViewModel = new KivalasztasPage_ViewModel();
        _keresesPageViewModel = new KeresesPage_ViewModel();
        _megszamolasPageViewModel = new MegszamolasPage_ViewModel();

        _mainViewModel.MenuClicked += new EventHandler(ViewModel_MenuClicked);

	}

	private void ViewModel_MenuClicked(Object? sender, EventArgs e)
	{
		switch (sender.ToString())
		{
            case "Sum": Sum_Clicked();
				break;
			case "ELdontes": Eldontes_Clicked();
				break;
			case "Kivalasztas": Kivalasztas_Clicked();
				break;
			case "Kereses": Kereses_Clicked();
				break;
			case "Megszamolas": Megszamolas_Clicked();
				break;
			default: DisplayAlert("Hiányzó tétel", "A tétel még nem elérhető", "OK");
				break;
        }
	}

    private void Sum_Clicked()
	{
		Navigation.PushAsync(new Sum_Page
		{
			BindingContext = _sumPageViewModel,
		});
	}

    private void Eldontes_Clicked()
    {
        Navigation.PushAsync(new Eldontes_Page
        {
            BindingContext = _eldontesPageViewModel,
        });
    }
    private void Kivalasztas_Clicked()
    {
        Navigation.PushAsync(new Kivalasztas_Page
        {
            BindingContext = _kivalasztasPageViewModel,
        });
    }
    private void Kereses_Clicked()
    {
        Navigation.PushAsync(new Kereses_Page
        {
            BindingContext = _kivalasztasPageViewModel,
        });
    }
    private void Megszamolas_Clicked()
    {
        Navigation.PushAsync(new Megszamolas_Page
        {
            BindingContext = _kivalasztasPageViewModel,
        });
    }
}
