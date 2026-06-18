    namespace ATMFinder.Domain.Entities
    {
        public class Bank
        {
            public int Id { get; set; }

            public string Name { get; set; } = default!; 

            public string Code { get; set; } = default!; 

            public ICollection<ATM> ATMs { get; set; } = default!; 
        }
    }
