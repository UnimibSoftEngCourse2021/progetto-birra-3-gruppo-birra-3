func @_ProgettoBirra.FormEliminaProd.buttonEliminaProd_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :21 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :21 :45)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :21 :45)
%1 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :21 :60)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :21 :60)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :23 :12) // Not a variable of known type: database
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :23 :32) // Not a variable of known type: textBoxNomeProd
%4 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :23 :32) // textBoxNomeProd.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :23 :12) // database.DeleteProd(textBoxNomeProd.Text) (InvocationExpression)
%6 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :25 :43) // new FormGestioneProdotti() (ObjectCreationExpression)
%8 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :26 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :26 :12) // this.Hide() (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :27 :12) // this (ThisExpression)
%11 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :27 :12) // this.Close() (InvocationExpression)
%12 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :28 :12) // Not a variable of known type: newform
%13 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :28 :12) // newform.ShowDialog() (InvocationExpression)
%14 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :29 :12) // this (ThisExpression)
%15 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormEliminaProd.cs" :29 :12) // this.Show() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
