elf_cals <- 0
elves_cals <- list()
f <- file("input-1.txt")
l <- readLines(f)
close(f)
x <- 0
for (idx in l) {
    if (idx != "") {
        elf_cals <- elf_cals + strtoi(idx)
    } else {
        elves_cals <- append(elves_cals, elf_cals)
        #print(elf_cals)
        elf_cals <- 0
    }
}
max_cals <- max(unlist(elves_cals))
print(max_cals)