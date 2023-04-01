namespace JWTToken.Models
{
    public class studentRepository : Istudent
    {
        private readonly DataBaseContext context;
        public studentRepository(DataBaseContext context)
        {
            this.context = context;
        }
        public List<Student> GetStudents()
        {
            return context.student.ToList();
        }
    }
}
