using CadastroEventosApp.Models;

namespace CadastroEventosApp.Views;

public partial class CadastroEventoPage : ContentPage
{
	private Evento evento;

	public CadastroEventoPage()
	{
		InitializeComponent();
		
		evento = new Evento
		{
			DataInicio = DateTime.Today,
			DataTermino = DateTime.Today.AddDays(1)
		};

		BindingContext = evento;
	}

	private async void OnCadastrarClicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(evento.Nome))
		{
			await DisplayAlert("Erro", "Por favor, informe o nome do evento.", "OK");
			return;
		}

		if (string.IsNullOrWhiteSpace(evento.Local))
		{
			await DisplayAlert("Erro", "Por favor, informe o local do evento.", "OK");
			return;
		}

		if (evento.NumeroParticipantes <= 0)
		{
			await DisplayAlert("Erro", "O número de participantes deve ser maior que zero.", "OK");
			return;
		}

		if (evento.CustoPorParticipante < 0)
		{
			await DisplayAlert("Erro", "O custo por participante não pode ser negativo.", "OK");
			return;
		}

		if (evento.DataTermino < evento.DataInicio)
		{
			await DisplayAlert("Erro", "A data de término não pode ser anterior à data de início.", "OK");
			return;
		}

		await Navigation.PushAsync(new ResumoEventoPage(evento));
	}
}
