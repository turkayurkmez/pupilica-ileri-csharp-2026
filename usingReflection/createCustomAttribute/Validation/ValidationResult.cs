using System;
using System.Collections.Generic;
using System.Text;

namespace createCustomAttribute.Validation
{
    public class ValidationResult
    {
        public bool IsValid => Errors.Count == 0;
        public List<string> Errors { get; } = [];


    }
}
