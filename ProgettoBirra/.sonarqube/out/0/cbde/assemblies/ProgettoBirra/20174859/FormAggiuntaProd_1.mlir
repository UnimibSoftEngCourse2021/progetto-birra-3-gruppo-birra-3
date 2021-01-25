func @_ProgettoBirra.FormAggiuntaProd.checkBox1_CheckedChanged$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :46)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :46)
%1 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :61)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :61)
br ^0

^0: // ExitBlock
return

}
func @_ProgettoBirra.FormAggiuntaProd.buttonSalvaProd$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :27 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :27 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :27 :37)
%1 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :27 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :27 :52)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :30 :12) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :30 :32) // Globals.emailGlobal (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :30 :53) // Not a variable of known type: textBoxNomeProd
%5 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :30 :53) // textBoxNomeProd.Text (SimpleMemberAccessExpression)
// Entity from another assembly: Convert
%6 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :30 :91) // this (ThisExpression)
%7 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :30 :91) // this.textBoxQuantita (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :30 :91) // this.textBoxQuantita.Text (SimpleMemberAccessExpression)
%9 = cbde.unknown : i32 loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :30 :75) // Convert.ToInt32(this.textBoxQuantita.Text) (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :30 :12) // database.InsertProd(Globals.emailGlobal, textBoxNomeProd.Text, Convert.ToInt32(this.textBoxQuantita.Text)) (InvocationExpression)
%11 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :33 :43) // new FormGestioneProdotti() (ObjectCreationExpression)
%13 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :34 :12) // this (ThisExpression)
%14 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :34 :12) // this.Hide() (InvocationExpression)
%15 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :35 :12) // this (ThisExpression)
%16 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :35 :12) // this.Close() (InvocationExpression)
%17 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :36 :12) // Not a variable of known type: newform
%18 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :36 :12) // newform.ShowDialog() (InvocationExpression)
%19 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :37 :12) // this (ThisExpression)
%20 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :37 :12) // this.Show() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
