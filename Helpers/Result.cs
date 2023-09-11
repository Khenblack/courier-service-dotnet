// namespace CourierServiceDotnet.Helpers
// {
//     public class Result<U>
//     {
//         protected Result(bool success, U error)
//         {
//             if (success && error != null)
//                 throw new InvalidOperationException();
//             if (!success && error == null)
//                 throw new InvalidOperationException();
//             Success = success;
//             Error = error;
//         }

//         public bool Success { get; }
//         public U Error { get; }
//         public bool IsFailure => !Success;

//         public static Result Fail(U error)
//         {
//             return new Result<U>(false, error);
//         }

//         public static Result<T> Fail<T>(string message)
//         {
//             return new Result<T>(default, false, message);
//         }

//         public static Result Ok()
//         {
//             return new Result(true, string.Empty);
//         }

//         public static Result<T> Ok<T>(T value)
//         {
//             return new Result<T>(value, true, string.Empty);
//         }
//     }

//     public class Result<T, U> : Result
//     {
//         protected internal Result(T value, bool success, U error)
//             : base(success, error)
//         {
//             Value = value;
//         }

//         public T Value { get; set; }
//     }
// }