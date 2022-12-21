/* https://www.cs.utah.edu/~germain/PPS/Topics/C_Language/file_IO.html
 * C code to read a bunch of integers from a file...
 * https://www.cs.uic.edu/~jbell/CourseNotes/C_Programming/basicTextFileIO.html
 * https://www.ibm.com/docs/en/i/7.4?topic=functions-strlen-determine-string-length
 * https://www.ibm.com/docs/en/i/7.4?topic=functions-fgets-read-string
 * https://www.ibm.com/docs/en/i/7.4?topic=functions-feof-test-end-file-indicator
 * https://www.ibm.com/docs/en/i/7.4?topic=functions-atoi-convert-character-string-integer
 * https://www.ibm.com/docs/en/i/7.4?topic=functions-scanf-read-data
 * scanf interrupts program execution to wait for user input
 * https://www.ibm.com/docs/en/i/7.4?topic=functions-fscanf-read-formatted-data
 * Don't use fscanf b/c ignores newlines, delimiter between elves
 * https://www.ibm.com/docs/en/i/7.4?topic=functions-isalnum-isxdigit-test-integer-value#isalnum
 * an alternative to comparison with "\n"
 * https://stackoverflow.com/a/3683613/1020470
 * In C and in C++ single quotes identify a single character, while double
 * quotes create a string literal. 'a' is a single a character literal, while
 * "a" is a string literal containing an 'a' and a null terminator (that is a 2
 * char array)
 * https://www.oreilly.com/library/view/c-in-a/0596006977/re105.html
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_LEN 80
#define MAXPATH 1024

int main() {

    int number;
    int ctr = 0;
    char line[MAX_LEN], *result;
    int calories = 0;
    int  maxcals = 0;
    char sPath[MAXPATH] = "";
    char *pTmp;  // temp pointer to HOME
    char folderpath[] = "/Projects/AOC/";
    char filepath[] = "input-1.txt";

    if (( pTmp = getenv( "HOME" )) != NULL ) {
        strncpy( sPath, pTmp, MAXPATH-1 ); // Save a copy for our use.
        printf("HOME is: %s\n", sPath);
        strcat(sPath, folderpath);
        strcat(sPath, filepath);
        printf("Concatenated String: %s\n", sPath);
    } else {
        fprintf( stderr, "No PATH variable set.\n") ;
    }

    FILE *stream = fopen(sPath, "r"); // read only

    if ( !stream ) // equivalent to saying if ( stream == NULL )
    {
        printf("oops, file can't be read\n");
        exit(-1);
    }

    while ( !feof(stream) ) {
        if ( (result = fgets(line, MAX_LEN, stream)) != NULL ) {
            // single quotes for characters, see above
            // atoi returns zero if result is not a number
            // https://stackoverflow.com/a/3214922/1020470
            if ( line[0] != '\n' ) {
                number = atoi(result);
                calories += number;
            } else {
                if (calories > maxcals) {
                    maxcals = calories;
                }
                calories = 0;
            }
        }
    }
    printf("The max cals is %d\n", maxcals);
    return 0;
}