import pathlib

inputfile = pathlib.Path('input-1.txt')
elves = []  # list of each elf's calories
elf_totcals = []  # list of each elf's total calories
with inputfile.open() as f:
    elves.append([]) 
    num_elves = len(elves) - 1
    for elf_cals in f:
        # reads each line including newline
        try:
            elf_cals = int(elf_cals.strip())
        except ValueError:
            # int('') raises exception, delimits elves
            elf_totcals.append(sum(elves[num_elves]))
            elves.append([])
            num_elves = len(elves) - 1
        else:
            elves[num_elves].append(elf_cals)
max_cals = max(elf_totcals)
elf_idx = elf_totcals.index(max_cals)
print(f'max cals: {max_cals} by elf #{elf_idx}')