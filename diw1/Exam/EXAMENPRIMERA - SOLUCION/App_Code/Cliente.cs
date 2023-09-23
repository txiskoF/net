using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cliente
/// </summary>
public class Cliente
{
    private int codigo;
    private string nombre;
    private DateTime fNacimiento;
    private string sexo;
    private int cargosMenores;
    private int cargosMayores;
    private string actividades;
    private int tipoEntrada;

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public DateTime FNacimiento
    {
        get { return fNacimiento; }
        set { fNacimiento = value; }
    }
    public string Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }
    public int CargosMenores
    {
        get { return cargosMenores; }
        set { cargosMenores = value; }
    }
    public int CargosMayores
    {
        get { return cargosMayores; }
        set { cargosMayores = value; }
    }
    public string Actividades
    {
        get { return actividades; }
        set { actividades = value; }
    }
    public int TipoEntrada
    {
        get { return tipoEntrada; }
        set { tipoEntrada = value; }
    }

    public Cliente()
    {
    }


    public Cliente(int cod, string nom, DateTime fnac, string sexo, int cargosm, int cargosM, string act, int tipoE)
    {
        this.Codigo = cod;
        this.Nombre = nom;
        this.FNacimiento = fnac;
        this.Sexo = sexo;
        this.CargosMenores = cargosm;
        this.CargosMayores = cargosM;
        this.Actividades = act;
        this.TipoEntrada = tipoE;
    }

    public byte calcularEdad()
    {
        int anios = DateTime.Now.Subtract(fNacimiento).Days;
        return Convert.ToByte(anios / 365);
    }

    public double calcularTarifa()
    {
        double tarifa;
        double[] tarifasJ = new double[] { 3.45, 14.45, 23.20, 10.80, 79.55 };
        double[] tarifasA = new double[] { 6.85, 29.10, 46.60, 17.40, 128.55 };
        byte edad=calcularEdad();
        if ( edad< 26 || edad> 65)
        {
            tarifa = calcularTarifasCargos(tarifasJ);
        }
        else
        {
            tarifa = calcularTarifasCargos(tarifasA);
        }
        return tarifa;
    }


    public double calcularTarifasCargos(double[] tarifas){

        double tarifa;

        if (tipoEntrada == 3)
        {
            tarifa = tarifas[tipoEntrada] + cargosMenores * 1.70 + cargosMayores * 3.75;

        }
        else if (tipoEntrada == 4)
        {
            tarifa = tarifas[tipoEntrada] + cargosMenores * 12.45 + cargosMayores * 27.85;
        }

        else
        {
            tarifa = tarifas[tipoEntrada];
        }
        return tarifa;
    
    }
}