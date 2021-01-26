func @_ProgettoBirra.FormAggiuntaProd.buttonSalvaProd$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :17 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :17 :37)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :17 :37)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :17 :52)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :17 :52)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :12) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :32) // Globals.emailGlobal (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :53) // Not a variable of known type: textBoxNomeProd
%5 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :53) // textBoxNomeProd.Text (SimpleMemberAccessExpression)
// Entity from another assembly: Convert
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :91) // this (ThisExpression)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :91) // this.textBoxQuantita (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :91) // this.textBoxQuantita.Text (SimpleMemberAccessExpression)
%9 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :75) // Convert.ToInt32(this.textBoxQuantita.Text) (InvocationExpression)
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :22 :12) // database.InsertProd(Globals.emailGlobal, textBoxNomeProd.Text, Convert.ToInt32(this.textBoxQuantita.Text)) (InvocationExpression)
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :26 :12) // this (ThisExpression)
%12 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :26 :12) // this.Close() (InvocationExpression)
%13 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :27 :12) // this (ThisExpression)
%14 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaProd.cs" :27 :12) // this.Dispose() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
