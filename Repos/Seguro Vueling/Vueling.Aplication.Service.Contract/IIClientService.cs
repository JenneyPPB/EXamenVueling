namespace Vueling.Aplication.Service.Contract
{
    interface IIClientService
    {
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}