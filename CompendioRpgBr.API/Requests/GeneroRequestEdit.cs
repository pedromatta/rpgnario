namespace CompendioRpgBr.API.Requests;

public record GeneroRequestEdit(int Id, string Nome, string Descricao) : GeneroRequest(Nome, Descricao);
