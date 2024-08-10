using System;

namespace BibliotecaReview;

public abstract class Pessoa : IPessoa
{
	
	// Propriedade com getters públicos e setters privados para melhor encapsulamento
	public string Nome { get; private set; }
	public DateTime DataNascimento { get; private set; }
	
	protected Pessoa(string nome, DateTime dataNascimento)
	{
		if (string.IsNullOrEmpty(nome))
			throw new ArgumentException("O nome não pode ser nulo ou vazio.", nameof(nome))	;
			
		Nome = nome ;
		DataNascimento = dataNascimento;
	}
	
	// Método com tratamento de excessão
	public virtual void ExibirInformacoes()
	{
		try
		{
			if (Nome == null || DataNascimento == default)
			{
				throw new InvalidOperationException("As informações estão incompletas.");
			}
			
			Console.WriteLine($"Nome: {Nome}\nData de Nascimento: {DataNascimento.ToShortDateString()}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Erro ao exibir as informações: {ex.Message}");
		}
	}
}