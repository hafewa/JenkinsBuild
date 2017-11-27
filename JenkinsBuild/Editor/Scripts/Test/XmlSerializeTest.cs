﻿using System;
using JenkinsBuild;
using JenkinsBuild.XmlEntity;
using NUnit.Framework;
using UnityEngine;

public class XmlSerializeTest {

	[Test]
	public void Xml序列化测试()
	{
        JenkinsAdapter.SerializerXml(Application.dataPath +
	                   @"/Plugins\JenkinsBuild\JenkinsBuild\Editor\Scripts\Test\TestAndroidBuildInfo.config");
	    var android = (BuildInfoBuildTypeAndroid) JenkinsAdapter.BuildInfo.BuildType.Item;

	    Console.WriteLine(android.BuildSystemSpecified);

        Assert.IsNotNull(JenkinsAdapter.BuildInfo);
    }

}