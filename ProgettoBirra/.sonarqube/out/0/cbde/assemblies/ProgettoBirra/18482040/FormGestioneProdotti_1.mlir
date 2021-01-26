func @_ProgettoBirra.FormGestioneProdotti.buttonAggiungi$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :25 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :25 :36)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :25 :36)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :25 :51)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :25 :51)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :27 :39) // new FormAggiuntaProd() (ObjectCreationExpression)
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :28 :12) // this (ThisExpression)
%5 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :28 :12) // this.Close() (InvocationExpression)
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :29 :12) // this (ThisExpression)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :29 :12) // this.Dispose() (InvocationExpression)
%8 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :30 :12) // Not a variable of known type: newform
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :30 :12) // newform.ShowDialog() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.FormGestioneProdotti.listBox1_SelectedIndexChanged$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :37 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :37 :51)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :37 :51)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :37 :66)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :37 :66)
br ^0

^0: // BinaryBranchBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :39 :16) // Not a variable of known type: listBox1
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :39 :16) // listBox1.SelectedItem (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :39 :41) // null (NullLiteralExpression)
%5 = cbde.unknown : i1  loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :39 :16) // comparison of unknown type: listBox1.SelectedItem != null
cond_br %5, ^1, ^2 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :39 :16)

^1: // SimpleBlock
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :41 :37) // Not a variable of known type: listBox1
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :41 :37) // listBox1.SelectedItem (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :41 :37) // listBox1.SelectedItem.ToString() (InvocationExpression)
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :43 :16) // this (ThisExpression)
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :43 :16) // this.Close() (InvocationExpression)
%12 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :44 :16) // this (ThisExpression)
%13 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :44 :16) // this.Dispose() (InvocationExpression)
%14 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :45 :64) // Not a variable of known type: selezionato
%15 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :45 :43) // new FormModificaProd(selezionato) (ObjectCreationExpression)
%17 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :46 :16) // Not a variable of known type: newform
%18 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormGestioneProdotti.cs" :46 :16) // newform.ShowDialog() (InvocationExpression)
br ^2

^2: // ExitBlock
return

}
