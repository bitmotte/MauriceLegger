firstattempt=true
userpath=""

currentdir=$(pwd)

rm ${currentdir}/resources/leg.bundle

echo ""
echo "finding bundle. . ."

userpath="../MLegBundle/"
currentdir=$(pwd)

cd ${userpath}Library/com.unity.addressables/aa/Windows/StandaloneWindows64/

bundle=$(find . -maxdepth 1 -name "*defaultlocalgroup*")
bundle=${bundle#./}

cd ${currentdir}

echo "copying bundle to project resources"
cp "${userpath}Library/com.unity.addressables/aa/Windows/StandaloneWindows64/${bundle}" "./resources/leg.bundle"
echo "done! ! !"
