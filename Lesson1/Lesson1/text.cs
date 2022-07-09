namespace Lesson1
{
    public class text
    {

        private string? firstName;
        private string? lastName;
        private string? patronymic;
        private string? email;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;

        }

        public string Patronymic
        {
            get => patronymic;
            set => patronymic = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public text(string s)
        {
            var split = s.Split(new char[] { ' ' });
            this.firstName = split[0];
            this.lastName = split[1];
            this.patronymic = split[2];
            this.email = split[4];

        }
    }
}
