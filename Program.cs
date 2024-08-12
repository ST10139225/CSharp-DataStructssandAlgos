// See https://aka.ms/new-console-template for more information

page firstPage = new page { Content = "Sola Gracia" };
page secondPage = new page { Content = "Sola Fede" };
page ThirdPage = new page { Content = "Solas Scriptura" };
page FourthPage = new page { Content = "Soli Deo Gloria" };
page FivePage = new page { Content = "Sola Christos" };
page SixPage = new page { Content = "Sola Zoe" };

LinkedList<page> pages = new LinkedList<page>(); 

pages.AddLast(secondPage);
LinkedListNode<page> fouthPageNOde = pages.AddLast(FourthPage);
pages.AddFirst(firstPage);  
pages.AddBefore(fouthPageNOde,ThirdPage);
pages.AddAfter(fouthPageNOde,FivePage);
pages.AddLast(SixPage);


