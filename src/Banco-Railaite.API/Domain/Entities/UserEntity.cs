namespace Banco_Railaite.Domain.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public int AccountType { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public double Balance { get; set; }
    }
}
