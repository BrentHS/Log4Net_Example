using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log4NetExample
{
	using System.Reflection;

	using log4net;

	class TestClass
	{
		private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void ImAnotherClass()
		{
			_log.Debug("Some more logging!");
		}
	}
}
