section .data
	string:     db 'Student Number: z12-332',10   	; 'Student Number' plus a linefeed character
	            db 'Last Name: Ada',10            		; 'Last Name' plus a linefeed character
	            db 'First Name: Ona',10            		; 'Last Name' plus a linefeed character
	            db 'Middle Name: Hadid',10         		; 'Middle Name' plus a linefeed character
	            db 'Course: EE',10                 		; 'Course' plus a linefeed character
	            db 'Year Level: 2022-2023',10     		; 'Year Level' plus a linefeed character
	stringLen:  equ $-string                       		; Length of the 'number' string

section .text
	global _start

_start:
	mov eax,4           	; The system call for write (sys_write)
	mov ebx,1           	; File descriptor 1 - standard output
	mov ecx,string      	; Put the offset of number in ecx
	mov edx,stringLen     ; numberLen is a constant, so we don't need to say
	                    	 ;  mov edx,[numberLen] to get it's actual value
	int 80h              	 ; Call the kernel
	mov eax,1           	 ; The system call for exit (sys_exit)
	mov ebx,0           	 ; Exit with return "code" of 0 (no error)
	int 80h;