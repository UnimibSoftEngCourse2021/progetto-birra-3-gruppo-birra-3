func @_ProgettoBirra.FormModificaAtt.buttonSalvaModifiche_Click$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :24 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :24 :48)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :24 :48)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :24 :63)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :24 :63)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :26 :12) // Not a variable of known type: database
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :26 :31) // Not a variable of known type: textBoxNomeAtt
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :26 :31) // textBoxNomeAtt.Text (SimpleMemberAccessExpression)
// Entity from another assembly: Convert
%5 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :26 :68) // this (ThisExpression)
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :26 :68) // this.numericUpDown1 (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :26 :68) // this.numericUpDown1.Text (SimpleMemberAccessExpression)
%8 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :26 :52) // Convert.ToInt32(this.numericUpDown1.Text) (InvocationExpression)
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :26 :12) // database.UpdateAtt(textBoxNomeAtt.Text, Convert.ToInt32(this.numericUpDown1.Text)) (InvocationExpression)
// Entity from another assembly: MessageBox
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :27 :28) // "L'attrezzo è stato modificato con successo" (StringLiteralExpression)
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :27 :12) // MessageBox.Show("L'attrezzo è stato modificato con successo") (InvocationExpression)
%12 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :33 :12) // this (ThisExpression)
%13 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :33 :12) // this.Close() (InvocationExpression)
%14 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :34 :12) // this (ThisExpression)
%15 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :34 :12) // this.Dispose() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.FormModificaAtt.buttonElimina_Click$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :37 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :37 :41)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :37 :41)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :37 :56)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :37 :56)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :39 :12) // Not a variable of known type: database
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :39 :31) // Not a variable of known type: textBoxNomeAtt
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :39 :31) // textBoxNomeAtt.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :39 :12) // database.DeleteAtt(textBoxNomeAtt.Text) (InvocationExpression)
// Entity from another assembly: MessageBox
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :40 :28) // "L'attrezzo è stato rimosso dal magazzino" (StringLiteralExpression)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :40 :12) // MessageBox.Show("L'attrezzo è stato rimosso dal magazzino") (InvocationExpression)
%8 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :46 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :46 :12) // this.Close() (InvocationExpression)
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :47 :12) // this (ThisExpression)
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :47 :12) // this.Dispose() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.FormModificaAtt.FormModificaAtt_Load$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :50 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :50 :42)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :50 :42)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :50 :57)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormModificaAtt.cs" :50 :57)
br ^0

^0: // ExitBlock
return

}
