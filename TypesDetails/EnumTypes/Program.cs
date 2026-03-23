using EnumTypes;

Console.WriteLine("Hello, World!");
Student student1 = new Student { Name = "Alice", Score = 85, State = StudentState.Graduate };

switch (student1.State)
{
	case StudentState.Graduate:
		break;
	case StudentState.Failed:
		break;
	case StudentState.Unknown:
		break;
	case StudentState.Canceled:
		break;
	default:
		break;
}


