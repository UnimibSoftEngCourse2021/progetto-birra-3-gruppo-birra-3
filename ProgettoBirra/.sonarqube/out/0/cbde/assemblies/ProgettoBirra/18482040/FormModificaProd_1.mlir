func @_ProgettoBirra.FormModificaProd.buttonSalvaModifiche_Click$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :29 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :29 :48)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :29 :48)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :29 :63)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :29 :63)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :31 :12) // Not a variable of known type: database
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :31 :32) // Not a variable of known type: textBoxNome
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :31 :32) // textBoxNome.Text (SimpleMemberAccessExpression)
// Entity from another assembly: Convert
%5 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :31 :66) // this (ThisExpression)
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :31 :66) // this.numericUpDown1 (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :31 :66) // this.numericUpDown1.Text (SimpleMemberAccessExpression)
%8 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :31 :50) // Convert.ToInt32(this.numericUpDown1.Text) (InvocationExpression)
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :31 :12) // database.UpdateProd(textBoxNome.Text, Convert.ToInt32(this.numericUpDown1.Text)) (InvocationExpression)
// Entity from another assembly: MessageBox
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :32 :28) // "Il prodotto è stato modificato con successo" (StringLiteralExpression)
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :32 :12) // MessageBox.Show("Il prodotto è stato modificato con successo") (InvocationExpression)
%12 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :38 :12) // this (ThisExpression)
%13 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :38 :12) // this.Close() (InvocationExpression)
%14 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :39 :12) // this (ThisExpression)
%15 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :39 :12) // this.Dispose() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.FormModificaProd.Button_elimina$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :43 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :43 :36)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :43 :36)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :43 :51)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :43 :51)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :45 :12) // Not a variable of known type: database
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :45 :32) // Not a variable of known type: textBoxNome
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :45 :32) // textBoxNome.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :45 :12) // database.DeleteProd(textBoxNome.Text) (InvocationExpression)
// Entity from another assembly: MessageBox
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :46 :28) // "Il prodotto è stato rimosso dalla dispensa" (StringLiteralExpression)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :46 :12) // MessageBox.Show("Il prodotto è stato rimosso dalla dispensa") (InvocationExpression)
%8 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :52 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :52 :12) // this.Close() (InvocationExpression)
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :53 :12) // this (ThisExpression)
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :53 :12) // this.Dispose() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.FormModificaProd.FormModificaProd_Load$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :57 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :57 :43)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :57 :43)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :57 :58)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaProd.cs" :57 :58)
br ^0

^0: // ExitBlock
return

}
