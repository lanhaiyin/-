#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <string.h>
#include <fcntl.h>
#include <ctype.h>
//启动一个父进程，父进程从标准输入里面读取用户输入的内容
//父进程区分用户输入的内容当中哪部分是命令，哪部分是命令行参数
//eg：ls -l  ls是命令 -l是参数
//父进程fork出来一个子进程，让子进程去进行程序替换，执行用户输入的命令，
//父进程等待子进程退出
//等待到子进程退出之后，进入循环去获取用户的输入

char command[1024];
char ** Deal_command(char *buff)
{
  char *command=buff;
   if(command==NULL||*command=='\0')
    exit(-1);
   int argc=0;
   static char* argv[1024];
     while(*command)
    {
        if(!isspace(*command))//不是空格存入
        {
            argv[argc++]=command;
          //找下一个空格
             while(!isspace(*command)&&*command!='\0')
           {
               command++;
           }
        }
       else{
             while(isspace(*command))
            {
               *command='\0';
               command++;
            }
         
          }
    }
   argv[argc]=NULL;
    int i=0;
    for(;i<argc;i++)
   {
      printf("%d:%s\n",i,argv[i]);
   }
return argv;  
}
int  do_exit(char *buff)
{
   char **argv={NULL};
   int ret=fork();
    if(ret==0)
     {
       //child
       argv= Deal_command(buff);
        if(argv[0]==NULL)
           exit(-1);
        //进行进程替换
        execvp(argv[0],argv);
     }
    else
    {
       waitpid(ret,NULL,0); 
    }
return 0;
}
int main()
{
    memset(command,'\0',sizeof(command));
 while(1)
{
  //用户输入
  fflush(stdout);
  if(fgets(command,sizeof(command)-1,stdin)==NULL)
    continue;
  else
    do_exit(command);
}

  return 0;
}
