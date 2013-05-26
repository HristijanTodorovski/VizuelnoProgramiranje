VizuelnoProgramiranje

WALLJUMP
=====================

C# Windows Forms

VizuelnoProgramiranje

WALLJUMP
=====================

C# Windows Forms

Апликацијата е семинарска по предметот Визуелно програмирање. Кодирана во WindowsForms C#- Microsoft Visual Studio 2012
Апликацијата е со цел да се покаже знањето по предметот и да се осознаат можностите на C#.
Апликацијата претставува 2D игра Скокач(Jumper) кој скока од една страна на друга , избегнувајќи ги непријателите
Ваша задача е со едноставно притискање на копчето од тастатура SPACE да го придвижувате човечето од лево на десно и обранот.
Во текот на играта имате 1 живот и во случај да се судрите со некој од непријателите ако не сте во скок играта завршува.

-----------------------------------

Имплементацијата на играта е почната од почеток не е земено код од друга имплементација на ваков вид на игри
Ваков вид на игри постојат повеќе од некои Андроид имплементации , WIN8 и слични платвофми .

------------------------------------

Податоции и класи
-Како податок кој се пренесува во секоја наредна игра е само најдобриот резултат од играњето
-класи кои се дел од овој проект се 
  Jumper (класа во која се чуваат сите податоци за човечето)
  Form1 (Место на целата имплементаија , копчинја , повици за движења и сл)
Enemy e главната класа каде се имплементирани основните позиција радиус од  оваа клса се изведуваат 2 подкласи за секој непријател посебно.
Мреза е класа која само служи за движење на една почетна слика
  Во играта може да се паузира , да го видите најдобриот резултат , да започнете нова игра и одкако ќе завршите со играње да си ја исклучите . На Help kопчето ќе добиете едноствно објаснување и ќе ви посакаме среќа.
Во позадината свири песна која и дава дополнителен ефект на играта 

  private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (igrica == 0)
            {
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawImage(slikaprva, 0, 0);
            }
            else if (igrica == 1)
            {

                //Iscrtuvanje na pozadinata na igrata
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawImage(zaz.Backpicture, 0, 0);
                e.Graphics.DrawImage(sid.getWall(), sid.getX(), sid.getY());
                sid.Wallsmove();
                e.Graphics.DrawImage(sid1.getWall(), sid1.getX(), sid1.getY());
                sid1.Wallsmove();
                e.Graphics.DrawImage(sid2.getWall(), sid2.getX(), sid2.getY());
                sid2.Wallsmove();
                e.Graphics.DrawImage(sid3.getWall(), sid3.getX(), sid3.getY());
                sid3.Wallsmove();
             // mestenje na jumperot na tocnite pozicii od koga ke izvrsi skok
                if (state == 1 && jump.positionx > 450) this.state = 2;
                if (state == 3 && jump.positionx < 80) this.state = 0;
                //State na koja strana i kako se dvizi jumperot 
                switch (state)
                {
                    case 0: { jump.trcalevo(); isHit(); break; }
                    case 1: { jump.pomestiNaDesnaStrana(); break; }
                    case 2: { jump.trcadesno();isHit(); break; }
                    case 3: { jump.pomestiNaLevaStrana(); break; }

                }
                //Dvizenje na neprijatelite vo samata igra
                foreach( Enemy en in listaneprijateli)
                {
                    en.enemymove();
                    e.Graphics.DrawImage(en.enem, en.positionx, en.positiony);
                    
                }
                //brsenje na neprijateli vo slucaj da ne se potrebni
                foreach (Enemy en in listaneprijateli)
                {
                    if (en.positiony > 800) listaneprijateli2.Add(en);
                        
                }
                //Nivno brisenje
                foreach (Enemy en in listaneprijateli2)
                {
                    listaneprijateli.Remove(en);
                }
                listaneprijateli2.Clear();
                //Vo slucaj da nema vise neprijateli vo igricata da se dodadat novi 
                generateenemy();
                //Iscrtuvanje na jumpman
                e.Graphics.DrawImage(jump.JumpMan, jump.positionx, jump.positiony);
                e.Graphics.DrawImage(m.slika, m.positionx, m.positiony);
                m.mrezamove();
              



                //System za resultattot
                resultat += kacuva;
                ts.Text = "Score: " + resultat.ToString();
            }
                //Faza 2 gameovder nekolku stafki sto da se sluci ako vi zavrsi igricata
            else if (igrica == 2)
            {
                gameover();
                //e.Graphics.DrawImage(end, 0, 0);
                e.Graphics.DrawImage(gameo, 0, 0);

            }
           // this.Invalidate();

        }




Почетен екран
<img src="http://i.imgur.com/Y3YwtcG.png" alt="Main Screen" />

Помош екранот
s <img src="http://i.imgur.com/ujLvHFW.png" alt="Main Screen" />




Дел од почетокот на играта

 s <img src="http://i.imgur.com/rurcra1.png" alt="Main Screen" />
Дел кај што имате непријатели и како тоа со скок се избегнуваат ротирајќи .


 
s <img src="http://i.imgur.com/WZQL0ad.png" alt="Main Screen" />

Крај на играта 

s <img src="http://i.imgur.com/Qt54YJ9.png" alt="Main Screen" />



  линк до мојата игра GITHUB : https://github.com/HristijanTodorovski/VizuelnoProgramiranje
