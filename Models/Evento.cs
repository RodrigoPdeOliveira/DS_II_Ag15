namespace CadastroEventosApp.Models;

public class Evento
{
    private string nome;
    private DateTime dataInicio;
    private DateTime dataTermino;
    private int numeroParticipantes;
    private string local;
    private decimal custoPorParticipante;

    public string Nome
    {
        get => nome;
        set
        {
            nome = value;
        }
    }

    public DateTime DataInicio
    {
        get => dataInicio;
        set
        {
            dataInicio = value;
        }
    }

    public DateTime DataTermino
    {
        get => dataTermino;
        set
        {
            dataTermino = value;
        }
    }

    public int NumeroParticipantes
    {
        get => numeroParticipantes;
        set
        {
            numeroParticipantes = value;
        }
    }

    public string Local
    {
        get => local;
        set
        {
            local = value;
        }
    }

    public decimal CustoPorParticipante
    {
        get => custoPorParticipante;
        set
        {
            custoPorParticipante = value;
        }
    }

    public int DuracaoEmDias
    {
        get
        {
            if (DataTermino >= DataInicio)
            {
                TimeSpan duracao = DataTermino - DataInicio;
                return duracao.Days + 1;
            }
            return 0;
        }
    }

    public decimal CustoTotal
    {
        get => NumeroParticipantes * CustoPorParticipante * DuracaoEmDias;
    }

}