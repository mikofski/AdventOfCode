f <- file("input-1.txt")
l <- readLines(f)
close(f)

elf_cals <- 0  # current elf's calorie totoal
elves_cals <- list()  # list of elves calorie totals

for (idx in l) {
    if (idx != "") {
        elf_cals <- elf_cals + strtoi(idx)
    } else {
        elves_cals <- append(elves_cals, elf_cals)
        elf_cals <- 0
    }
}

max_cals <- max(unlist(elves_cals))
print(max_cals)