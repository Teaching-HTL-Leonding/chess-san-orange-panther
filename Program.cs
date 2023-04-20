var moves = args;
for (int i = 0; i < moves.Length; i++)
{
    DecipherMove(moves[i], out string piece, out string position);
    System.Console.WriteLine($"{piece} moves to {position}");
}

void DecipherMove(string move, out string piece, out string position)
{
    if (move.Length == 2)
    {
        piece = "Pawn (♙ )";
        position = move;
    }
    else 
    {
        position = move.Substring(move.Length -2);
        piece = move.Substring(0, 1) switch {
            "B" => "Bishop (♗ )",
            "N" => "Knight (♘ )",
            "Q" => "Queen (♕ )",
            "R" => "Rook (♖ )",
            "K" => "King (♔ )",
            _ => ""
        };
    }
}
