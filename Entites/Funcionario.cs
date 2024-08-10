using System;

namespace BibliotecaReview;

public class Funcionario : Pessoa
{
	// Propriedade com getters públicos e setters privados para melhor encapsulamento
	public int Id { get; private set; }
	public string Cargo { get; private set; }
	public DateTime DataAdmissao { get; private set; }
	
	public Funcionario(int id, string cargo, DateTime dataAdmissao, string nome, DateTime dataNascimento) : base(nome, dataNascimento)
	{
		if (string.IsNullOrEmpty (cargo))
			throw new ArgumentNullException ("O cargo não pode ser nulo ou vazio", nameof (cargo));
		
		if (dataAdmissao > DateTime.Now)
			throw new ArgumentException ("A data não pode ser no futuro", nameof(dataAdmissao));
		
		Id = id;
		Cargo = cargo;
		DataAdmissao = dataAdmissao;
	}
	
	
	public override void  ExibirInformacoes()
	{
		base.ExibirInformacoes();
		
		Console.WriteLine($"ID: {Id}\nCargo: {Cargo}\nData de Adimissão: {DataAdmissao.ToString("dd-MM-yyyy")}");
	}
}