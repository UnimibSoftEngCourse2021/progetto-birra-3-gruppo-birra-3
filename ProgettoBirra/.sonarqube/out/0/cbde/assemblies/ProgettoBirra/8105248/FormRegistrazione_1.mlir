func @_ProgettoBirra.FormRegistrazione.buttonRegistrati$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :14 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :14 :38)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :14 :38)
%1 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :14 :53)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :14 :53)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :16 :12) // Not a variable of known type: database
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :16 :34) // Not a variable of known type: textBoxEmail
%4 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :16 :34) // textBoxEmail.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :16 :53) // Not a variable of known type: textBoxPassword
%6 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :16 :53) // textBoxPassword.Text (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :16 :12) // database.InsertUtente(textBoxEmail.Text, textBoxPassword.Text) (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :20 :32) // new FormLogin() (ObjectCreationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :21 :12) // this (ThisExpression)
%11 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :21 :12) // this.Hide() (InvocationExpression)
%12 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :22 :12) // this (ThisExpression)
%13 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :22 :12) // this.Close() (InvocationExpression)
%14 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :23 :12) // Not a variable of known type: newform
%15 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :23 :12) // newform.ShowDialog() (InvocationExpression)
%16 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :24 :12) // this (ThisExpression)
%17 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :24 :12) // this.Show() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.FormRegistrazione.textBox1_TextChanged$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :27 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :27 :42)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :27 :42)
%1 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :27 :57)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRegistrazione.cs" :27 :57)
br ^0

^0: // ExitBlock
return

}
