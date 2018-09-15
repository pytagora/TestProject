using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AddressBookUI
{
    class AddressBook
    {
#if DEBUG
        [DllImport(@"..\..\..\..\x64\Release_for_debug\AddressBookCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
#else
        [DllImport("AddressBookCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
#endif
        public static extern void test();

#if DEBUG
        [DllImport(@"..\..\..\..\x64\Release_for_debug\AddressBookCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
#else
        [DllImport("AddressBookCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
#endif  
        private static extern UIntPtr addressBookBinarySize();

#if DEBUG
        [DllImport(@"..\..\..\..\x64\Release_for_debug\AddressBookCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
#else
        [DllImport("AddressBookCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
#endif
        private static extern void getAddressBook(byte[] buffer, out int size);


        public static Abook.AddressBook getAddressBook()
        {
            
            Abook.AddressBook ab = new Abook.AddressBook();
            
            //prepare a memory block to get address book binary representation
            UIntPtr abBinarySize = addressBookBinarySize();
            byte[] binData = new byte[(int)abBinarySize];
            int size = 0;
            getAddressBook(binData, out size);

            //address book message parser
            Google.Protobuf.MessageParser<Abook.AddressBook> mp = new Google.Protobuf.MessageParser<Abook.AddressBook>(() => new Abook.AddressBook());

            try
            {
                //instantiate Address book from the binary array
                ab = mp.ParseFrom(binData);

                //show received address book
                System.Windows.MessageBox.Show(ab.ToString());

                foreach(var entry in ab.Entry)
                    Console.WriteLine(entry.FirstName);
            }
            catch(Google.Protobuf.InvalidProtocolBufferException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }

            return ab;
        }
    }
}
