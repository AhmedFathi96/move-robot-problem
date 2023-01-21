using System;
using Xunit;
using Task;
namespace MoveRobotTests;

public class UnitTest1
{
    [Fact]
    public void TestMoveRobotCase1(){
        MoveRobot robot = new MoveRobot(5,5);
        Assert.Equal("1,4,west", robot.move("FFRFLFLF"));
    }
    [Fact]
    public void TestMoveRobotCase2(){
        MoveRobot robot = new MoveRobot(1,1);
        Assert.Equal("1,1,north", robot.move("FFRFLFLF"));
    }
    [Fact]
    public void TestMoveRobotCase3(){
        MoveRobot robot = new MoveRobot(3,2);
        Assert.Equal("2,1,east", robot.move("FRFRFFFL"));
    }
    [Fact]
    public void TestMoveRobotCase4(){
        MoveRobot robot = new MoveRobot(2,2);
        Assert.Equal("1,1,north", robot.move("FFRRL"));
    }
    [Fact]
    public void TestMoveRobotCase5(){
        MoveRobot robot = new MoveRobot(16,16);
        Assert.Equal("1,3,west", robot.move("FFRFLFFRRFLLLFF"));
    }
}