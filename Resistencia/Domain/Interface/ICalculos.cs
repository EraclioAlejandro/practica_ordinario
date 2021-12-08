namespace Resistencia.Domain.Interface
{
    public interface ICalculos
    {
        void PrimerColor (string Color1);
        void SegundoColor(string Color2);
        void TercerColor(string Color3);
        void CuartoColor(string Color4);
        string RetornarCalculos();
    }
}