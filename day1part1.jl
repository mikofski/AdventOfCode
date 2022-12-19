# https://docs.julialang.org/en/v1/base/io-network/
# short way is like Python with context, closes file automatically
io = open(f->read(f, String), "input-1.txt");
# alternate long way
# io = open("input-1.txt");  # default is "r" for read
# explicitly read as String otherwise IO is raw bytes
# data = read(io, String);
# close(io);

# XXX: variables are read only inside loops, unless global is explicit
# https://stackoverflow.com/questions/54384593/why-do-julia-variables-not-exist-in-the-scope-of-for-loops
# https://docs.julialang.org/en/v1/manual/variables-and-scoping/
# https://discourse.julialang.org/t/error-variable-inside-a-loop/21504

function f(io)
    # https://www.matecdev.com/posts/julia-array-initialize.html
    # Int[] is shorthand Array{Int}(undef, 0)
    elf_totcals = Int[]  # list of calorie sums
    elves = Int[]  # list of elf's snacks
    # https://docs.julialang.org/en/v1/base/strings/
    # https://docs.julialang.org/en/v1/manual/control-flow/
    # https://docs.julialang.org/en/v1/base/iterators/
    # collect(eachsplit(data))  # requires Julia >= 1.8
    data = split(io, keepempty=true)
    # by default keepempty=false unless dlm is explicity, eg: dlm="\n"
    for snack in data
        # https://discourse.julialang.org/t/converting-strings-of-numbers-to-numbers/11164
        # more explicit alternative to try-catch
        # if snack != ""
        # else
        try
            cals = parse(Int, snack)
            append!(elves, cals)
        # raises ArgumentError: input string is empty or only contains whitespace
        catch
            totcals = sum(elves)
            append!(elf_totcals, totcals)
            elves = Int[]
        end
    end
    return elf_totcals
end

elves_snack_totcals = f(io)
max_elf_snack_cals = maximum(elves_snack_totcals)
print("max snack cals = ", max_elf_snack_cals, "\n")