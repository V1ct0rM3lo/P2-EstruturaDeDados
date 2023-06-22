using System;

// Definição da struct Funcionario
public struct Funcionario
{
    public string nome;
    public string cargo;
    public float salario;
    public int cargaHoraria;

    public void aumentoSalarialPorPromocaoEmValor(float valor)
    {
        salario += valor;
    }

    public void promover(string novoCargo, float aumentoSalario)
    {
        cargo = novoCargo;
        aumentoSalarialPorPromocaoEmValor(aumentoSalario);
    }

    public void descontoSalarialPorFaltaEmValor(float valor)
    {
        salario -= valor;
    }

    public void aumentarCargaHorariaDeTrabalho(int horas)
    {
        cargaHoraria += horas;
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Carga Horária: " + cargaHoraria);
    }
}
