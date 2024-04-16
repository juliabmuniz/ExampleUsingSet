using System;

namespace ExampleUsingSet.Entities {
    internal class User {
        public  int Code { get; set; }

        public User() {
        }

        public User(int code) {
            Code = code;
        }


        public override int GetHashCode() {
            return Code.GetHashCode();
        }
        public override bool Equals(object obj) {
            if (!(obj is User)) {
                return false;
            }
            User other = obj as User;
            return Code.Equals(other.Code);
        }
    }
}
