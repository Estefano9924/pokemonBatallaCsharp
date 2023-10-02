using POKEMON.Pokemon;

Console.WriteLine("Hola, Este es el juego de Pokemon, vamos a crear los pokemones para la siguente partida");
List<Pokemon> pokemons = new List<Pokemon>();
Pokemon pokemon1;
Pokemon pokemon2;

Boolean comparador(int prueba){
    
    if (prueba > 40)
    {
        Console.WriteLine("Uno de Los ataques es Mayor del valor solicitado");
        return false;
    }
    
    if (prueba < 0)
    {
        Console.WriteLine("Uno de Los ataques es menor del valor solicitado");
        return false;
    }

    return true;
}

for (int i = 1; i < 3; i++)
{

    Console.Write($"Ingrese el nombre del pokemon {i}: ");
    string nombre =Console.ReadLine();
    

    Console.Write($"Ingrese el tipo del pokemon {i}: ");
    string tipo = Console.ReadLine();

    Console.WriteLine("Recuerde al ingresar VALORES DE ATAQUES deben ser MAYORES A 0 y MENORES A 40");
    Console.WriteLine("Recuerde al ingresar VALORES DE DEFENSA deben ser MAYORES A 10 y MENORES A 35");

    Console.Write($"Ingrese el Ataque 1 del pokemon {i}: ");
    int ataque1 = Int32.Parse(Console.ReadLine());
    if(comparador(ataque1)==false){
        break;
    }

    Console.Write($"Ingrese el Ataque 2 del pokemon {i}: ");
    int ataque2 = Int32.Parse(Console.ReadLine());
    if(comparador(ataque2)==false){
        break;
    }

    Console.Write($"Ingrese el Ataque 3 del pokemon {i}: ");
    int ataque3 = Int32.Parse(Console.ReadLine());
    if(comparador(ataque3)==false){
        break;
    }

    Console.Write($"Ingrese el defensa del pokemon {i}: ");
    int defensa = Int32.Parse(Console.ReadLine());

    Console.WriteLine();

    if (defensa < 10 || defensa > 35)
    {
        Console.WriteLine("la defensa no esta en el rango solicitado");
        break;
    }
    Pokemon pokemon = new Pokemon(nombre, tipo, ataque1, ataque2, ataque3, defensa);
    pokemons.Add(pokemon);

}

pokemon1 = pokemons[0];
pokemon2 = pokemons[1];

int vidaPokemon1 = 100;
int vidaPokemon2 = 100;


for (int turno = 1; turno <= 3; turno++)
{
    Console.WriteLine($"Turno {turno}:");

    int ataq1 = pokemon1.Atacar();
    double def2 = pokemon2.Defender();
    int ataq2 = pokemon2.Atacar();
    double def1 = pokemon1.Defender();
    Console.WriteLine($"{pokemon1.getNombre()} ataca a {pokemon2.getNombre()} con {ataq1} puntos.");
    Console.WriteLine($"{pokemon2.getNombre()} defiende con {def2} puntos.");
    if (ataq1 > def2)
    {
        vidaPokemon2 -= (int)(ataq1 - def2);
    }
    Console.WriteLine($"la salud de {pokemon2.getNombre()} es {vidaPokemon2}");

    Console.WriteLine($"{pokemon2.getNombre()} ataca a {pokemon1.getNombre()} con {ataq2} puntos.");
    Console.WriteLine($"{pokemon1.getNombre()} defiende y reduce el daño a {def1} puntos.");
    if (ataq2 > def1){
    vidaPokemon1 -= (int)(ataq2 - def1);
    }
    Console.WriteLine($"la salud de {pokemon1.getNombre()} es {vidaPokemon1}");
}

if (vidaPokemon1 > vidaPokemon2)
{
    Console.WriteLine($"{pokemon1.getNombre()} gana la batalla con una salud de {vidaPokemon1}.");
}
else if (vidaPokemon2 > vidaPokemon1)
{
    Console.WriteLine($"{pokemon2.getNombre()} gana la batalla con una salud de {vidaPokemon2}.");
}
else
{
    Console.WriteLine("¡La batalla termina en empate!");
}

