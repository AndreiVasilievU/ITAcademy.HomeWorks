using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        //внутри своего класса все поля доступны
        private const int MinSpeedPrivate = 0;
        internal const int MinSpeedInternal = 0;
        public const int MinSpeedPublic = 0;
        protected const int MinSpeedProtected = 0;
        protected internal int MinSpeedProtectedInternal = 0;
        private protected int MinSpeedPrivateProtected = 0;

        private int MaxSpeedPrivate { get; set; }
        internal int MaxSpeedInternal { get; set; }
        public int MaxSpeedPublic { get; set; }
        protected int MaxSpeedProtected { get; set; }
        protected internal int MaxSpeedProtectedInternal { get; set; }
        private protected int MaxSpeedPrivateProtected { get; set; }


        private void MovePrivate() { }
        internal void MoveInternal() { }
        public void MovePublic() { }
        protected void MoveProtected() { }
        protected internal void MoveProtectedInternal() { }
        private protected void MovePrivateProtected() { }
    }
}
