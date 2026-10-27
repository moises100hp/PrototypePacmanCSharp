
using PrototypePacman;

// Cria um protótipo base do fantasma
var prototipoFantasmaBase = new FantasmaPacMan("Fantasma Base", "Transparente", "Errante", 5);

Console.WriteLine("--- Protótipo Base ---");
prototipoFantasmaBase.ExibirInfo();
prototipoFantasmaBase.Mover();

Console.WriteLine("\n--- Criando os Fantasmas do Pac-Man por Clonagem ---");

// Blinky (Vermelho - Persegue)
var blinky = (FantasmaPacMan)prototipoFantasmaBase.Clone();
blinky.Nome = "Blinky";
blinky.Cor = "Vermelho";
blinky.Comportamento = "Persegue Pac-Man diretamente";
blinky.Velocidade = 6;
blinky.ExibirInfo();
blinky.Mover();

// Pinky (Rosa - Emboscada)
var pinky = (FantasmaPacMan)prototipoFantasmaBase.Clone();
pinky.Nome = "Pinky";
pinky.Cor = "Rosa";
pinky.Comportamento = "Tenta emboscar Pac-Man";
pinky.ExibirInfo();
pinky.Mover();

// Inky (Ciano - Estrategista, depende de Blinky)
var inky = (FantasmaPacMan)prototipoFantasmaBase.Clone();
inky.Nome = "Inky";
inky.Cor = "Ciano";
inky.Comportamento = "Comportamento estratégico (depende de Blinky)";
inky.ExibirInfo();
inky.Mover();

// Clyde (Laranja - Foge ou Persegue)
var clyde = (FantasmaPacMan)prototipoFantasmaBase.Clone();
clyde.Nome = "Clyde";
clyde.Cor = "Laranja";
clyde.Comportamento = "Foge quando perto, persegue quando longe";
clyde.ExibirInfo();
clyde.Mover();

Console.WriteLine("\n--- Protótipo Base Original (Inalterado) ---");
prototipoFantasmaBase.ExibirInfo();