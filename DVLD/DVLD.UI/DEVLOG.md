## Session – 19 MAY 26 8pm

### What I Did

### What's Broken / Unfinished

### NEXT SESSION — Start Here
I have came to creating the "Detain license" From but I had to create the ctrl "ctrlDetainInfo" So I'm on this right now I have finished BLL and DAL of the LicenseDetention.
I need to find a way to get the license detention record from the license id and something else.

### Notes / Decisions Made


## Things needs to be fixed:
I need to fix if the license is not found in driver license to don't show the from at all!

### Future things to do:
1. Review DTO placement after finishing the project.



## Replacement for Damaged or Lost Licenses
- Replacement for Damaged or Lost Licenses FORM @2:54 
	- If license is inactive don't allow any operations @3:08
	- The replacement in this steps:
	1. Get license.
	1. Check if operation is for lost or damaged (It will be the issue reason "LicenseType").
	1. Create a new application depending on the operation.
	1. Copy all data from the old license to the new one(except some look at the reference at renew license).
	1. Deactivate the old license.


## Detain Licenses
- menu strip @ 1:09
- if license already detained don't allow! @3:18
- *Detain* don't need application but release needs
- When release check if it's detained

