namespace POKEMON.Pokemon;


public abstract class Animal : IAtaqueYDefensa
{
    Random random = new Random();
    private string Nombre { get; set;}
    private string Tipo { get; set;}
    private int Ataque1 { get; set;}
    private int Ataque2 { get; set;}
    private int Ataque3 { get; set;}
    private int Defensa { get; set;}



    public Animal(string nombre, string tipo, int ataque1, int ataque2, int ataque3, int defensa)
    {
        this.Nombre = nombre;
        this.Tipo = tipo;
        this.Ataque1 = ataque1;
        this.Ataque2 = ataque2;
        this.Ataque3 = ataque3;
        this.Defensa = defensa;
    }

    public string getNombre(){
        return this.Nombre;
    }

    public string getTipo(){
        return this.Tipo;
    }

    public int getAtaque1(){
        return this.Ataque1;
    }

    public int getAtaque2(){
        return this.Ataque2;
    }

    public int getAtaque3(){
        return this.Ataque3;
    }

    public int getDefensa(){
        return this.Defensa;
    }



    public int Atacar()
    {
        int numeroAleatorio = random.Next(1, 4);
        int ataque = 0;

        switch (numeroAleatorio)
        {
            case 1:
                ataque = this.Ataque1;
                break;
            case 2:
                ataque = this.Ataque2;
                break;
            case 3:
                ataque = this.Ataque3;
                break;
        }
        
        int multiplicador = random.Next(0, 2);
        return ataque * multiplicador;
    }

    public double Defender()
    {
        int aleatorio = random.Next(0,2);
        double multiplicador;
        if (aleatorio == 0)
        {
            multiplicador = 0.5;
        }else{
            multiplicador = 1.0;
        }

        return this.Defensa * multiplicador;
    }
}

