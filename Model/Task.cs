namespace first2 {
    public class Task {
        private int _id;
        private string _name;
        private string _description;
        private DateTime TaskDay;
        private bool isDone;
        public void TaskExceptions() {
        if(this._description.Length > 400) {
                throw new TaskLengthException("Завелика кількість символів.");
            }
            if (TaskDay < DateTime.Now)
            {
                throw new TaskDateException("Некоректна дата");
            }
            if(isDone) {
                throw new TaskDoneException("Задача/завдання виконане");
            }
        }
    }
}