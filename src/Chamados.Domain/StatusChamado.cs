namespace Chamados.Domain;

/// <summary>
/// Estados do ciclo de vida de um chamado.
/// </summary>
public enum StatusChamado
{
    Aberto,
    EmAtendimento,
    Resolvido,
    Cancelado
}