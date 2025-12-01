namespace gym.Models
{
    public partial class Exercise
    {
        public int ExerciseID { get; set; }

        public string Name { get; set; } = null!;

        public string? Category { get; set; }


        //todo add WorkoutExercises Model 11/30/2025
        //public  ICollection<WorkoutExercise> WorkoutExercises { get; set; } = new List<WorkoutExercises>
    }
}
